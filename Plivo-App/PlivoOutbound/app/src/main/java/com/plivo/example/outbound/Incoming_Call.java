package com.plivo.example.outbound;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.media.AudioManager;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.Incoming;

/**
 * Created by lijo on 29/7/15.
 */
public class Incoming_Call extends Activity {
    Endpoint endpoint = DataHolder.getEndpoint();
    Incoming incoming = DataHolder.getIncoming();
    boolean isSpeakerOn;
    boolean isMuteOn;
    private AudioManager myAudioManager;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Log.v("PlivoInbound", "Trying to log in");
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_incoming);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    public void hangupNow(View view) {
        Log.v("PlivoInbound", "Hanging up...");
        incoming.hangup();
        Intent intent = new Intent(Intent.ACTION_MAIN);
        intent.addCategory(Intent.CATEGORY_HOME);
        startActivity(intent);
    }

    public void answerNow(View view) {
        Log.v("PlivoInbound", "Answering");
        incoming.answer();
        Log.v("PlivoInbound", incoming.getHeader());
        Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
        Button answer_button = ((Button)findViewById(R.id.answer_btn));

        hangup_button.setClickable(true);


        answer_button.setClickable(false);
    }

    public void onBackPressed() {
        moveTaskToBack(true);
    }


    public void speakerOn(View view) {
        Log.v("PlivoOutbound", "Speaker btn pressed...");
        myAudioManager = (AudioManager) getSystemService(Context.AUDIO_SERVICE);
        if (!isSpeakerOn) {
            myAudioManager.setSpeakerphoneOn(true);
            isSpeakerOn = true;
        }
        else {
            myAudioManager.setSpeakerphoneOn(false);
            isSpeakerOn=false;
        }

    }

    public void muteOn(View view){
        if (!isMuteOn) {
            Log.v("PlivoPhone", "Mute");
            incoming.mute();
        }else{
            Log.v("PlivoPhone", "Unmute");
            incoming.unmute();
        }
    }
}
