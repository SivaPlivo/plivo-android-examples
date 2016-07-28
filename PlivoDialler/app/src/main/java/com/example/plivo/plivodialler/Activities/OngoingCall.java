package com.example.plivo.plivodialler.Activities;

import android.content.Context;
import android.content.Intent;
import android.media.AudioManager;
import android.media.Ringtone;
import android.media.RingtoneManager;
import android.net.Uri;
import android.os.Bundle;
import android.os.Vibrator;
import android.support.v7.app.AppCompatActivity;
import android.text.Editable;
import android.text.TextWatcher;
import android.util.Log;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.TextView;

import com.example.plivo.plivodialler.Utils.CommManager;
import com.example.plivo.plivodialler.R;

public class OngoingCall extends AppCompatActivity {

    CommManager mCommManager;
    Intent intent;

    TextView tvCallerID;
    EditText sendDigit;
    ImageButton ibAccept, ibReject, ibMute, ibSpeaker, ibDialpad;

    Uri notification;
    Ringtone mRingTone;
    Vibrator mVibrate;


    Boolean speakerToggle = false, muteToggle = false;
    AudioManager mAudioManager;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ongoing_call);

        mCommManager = CommManager.getInstance(this);

        ibAccept = (ImageButton) findViewById(R.id.ibAcceptCall);
        ibReject = (ImageButton) findViewById(R.id.ibRejectCall);
        ibMute = (ImageButton) findViewById(R.id.ibRecordAudio);
        ibSpeaker = (ImageButton) findViewById(R.id.ibSpeakerPhone);
        ibDialpad = (ImageButton) findViewById(R.id.ibShowDialpad);
        tvCallerID = (TextView) findViewById(R.id.tvShowNumber);
        sendDigit = (EditText) findViewById(R.id.dtmfDigits);

        mAudioManager = (AudioManager)getSystemService(Context.AUDIO_SERVICE);

        if (!mCommManager.isIncomingCall()){
            ibAccept.setEnabled(false);
            ibAccept.setVisibility(View.GONE);
        }else {
            notification = RingtoneManager.getDefaultUri(RingtoneManager.TYPE_RINGTONE);
            mRingTone = RingtoneManager.getRingtone(getApplicationContext(), notification);
            mRingTone.play();
        }

        tvCallerID.setText(mCommManager.getCallerID());

        ibAccept.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                mCommManager.incomingAnswer();
                mRingTone.stop();
                ibAccept.setVisibility(View.GONE);
                ibAccept.setEnabled(false);
            }
        });

        ibReject.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (ibAccept.isEnabled()){
                    mCommManager.incomingReject();
                    mRingTone.stop();
                }else{
                    if (mCommManager.isIncomingCall()) {
                        mCommManager.incomingHangup();
                    }else{
                        mCommManager.outgoingHangup();
                    }
                }
            }
        });

        ibMute.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (muteToggle){
                    mCommManager.callUnmute();
                    ibMute.setImageResource(R.drawable.ic_mic_off_black_24dp);
                    muteToggle = false;
                }else{
                    mCommManager.callMute();
                    muteToggle = true;
                    ibMute.setImageResource(R.drawable.ic_mic_black_24dp);
                }
            }
        });

        ibSpeaker.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (speakerToggle){
                    mAudioManager.setMode(AudioManager.MODE_NORMAL);
                    mAudioManager.setSpeakerphoneOn(false);
                    ibSpeaker.setImageResource(R.drawable.ic_volume_up_black_24dp);
                    speakerToggle = false;
                }else{
                    mAudioManager.setMode(AudioManager.MODE_IN_CALL);
                    mAudioManager.setSpeakerphoneOn(true);
                    ibSpeaker.setImageResource(R.drawable.ic_volume_off_black_24dp);
                    speakerToggle = true;
                }
            }
        });

        ibDialpad.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                sendDigit.setVisibility(View.VISIBLE);
                sendDigit.requestFocus();
                InputMethodManager imm = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
                imm.showSoftInput(sendDigit, InputMethodManager.SHOW_IMPLICIT);
            }
        });

        sendDigit.addTextChangedListener(new TextWatcher() {
            @Override
            public void beforeTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void onTextChanged(CharSequence charSequence, int i, int i1, int i2) {

            }

            @Override
            public void afterTextChanged(Editable editable) {
                String text = sendDigit.getText().toString();
                String digit = text.substring(text.length() - 1);
                Log.d("Digit Sent", digit);
                if (mCommManager.isIncomingCall()){
                    mCommManager.sendIncomingDigits(digit);
                }else{
                    mCommManager.sendOutgoingDigits(digit);
                }
            }
        });
    }

    @Override
    protected void onStop() {
        super.onStop();
        finish();
    }

    @Override
    protected void onPause() {
        super.onPause();
        finish();
    }

    @Override
    public void onBackPressed() {

    }
}
