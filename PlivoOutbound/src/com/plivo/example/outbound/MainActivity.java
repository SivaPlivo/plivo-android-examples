package com.plivo.example.outbound;

import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.media.AudioManager;
import android.net.Uri;
import android.os.Bundle;
import android.app.Activity;
import android.provider.ContactsContract;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import android.widget.ToggleButton;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.EventListener;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;

public class MainActivity extends Activity implements EventListener {

    public final static String EXTRA_MESSAGE = "com.plivo.example.MESSAGE";
    // Edit the variables below with your Plivo endpoint username and password
    public final static String PLIVO_USERNAME = "";
    public final static String PLIVO_PASSWORD = "";

    // Edit the PHONE_NUMBER with the number you want to make the call to
    public static String PHONE_NUMBER = "";
    private EditText number;
    private AudioManager myAudioManager;
    Endpoint endpoint = Endpoint.newInstance(true, this);
    Outgoing outgoing = new Outgoing(endpoint);

    // private final Context context;
    @Override
    protected void onCreate(Bundle savedInstanceState) {

        Log.v("PlivoOutbound", "Trying to log in");
        endpoint.login(PLIVO_USERNAME, PLIVO_PASSWORD);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        number = (EditText) findViewById(R.id.number);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    public void callNow(View view) {
        // Log into plivo cloud
        outgoing = endpoint.createOutgoingCall();
        Log.v("PlivoOutbound", "Create outbound call object");
        PHONE_NUMBER = number.getText().toString();
        Log.v("PlivoOutbound", PHONE_NUMBER);
        outgoing.call(PHONE_NUMBER);

    }

    public void getContacts(View view) {
        Intent intent = new Intent(Intent.ACTION_GET_CONTENT);
        intent.setType(ContactsContract.CommonDataKinds.Phone.CONTENT_ITEM_TYPE);
        startActivityForResult(intent, 1);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (data != null) {
            Uri uri = data.getData();

            if (uri != null) {
                Cursor c = null;
                try {
                    c = getContentResolver()
                            .query(uri,
                                    new String[] {
                                    ContactsContract.CommonDataKinds.Phone.NUMBER,
                                    ContactsContract.CommonDataKinds.Phone.TYPE },
                                    null, null, null);

                    if (c != null && c.moveToFirst()) {
                        String num = c.getString(0);
                        String _num = CallHelper.helpCall(num);
                        if (_num.length() > 0)
                            number.setText(_num);
                        else {
                            Toast.makeText(getApplicationContext(),
                                    "Number should start with country code",
                                    Toast.LENGTH_LONG).show();
                        }
                    }
                } finally {
                    if (c != null) {
                        c.close();
                    }
                }
            }
        }
    }

    public void hangupNow(View view) {
        Log.v("PlivoOutbound", "Hanging up...");
        outgoing.hangup();
        Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
        Button call_button = ((Button) findViewById(R.id.call_btn));
        hangup_button.setEnabled(false);
        hangup_button.setClickable(false);

        call_button.setEnabled(true);
        call_button.setClickable(true);
    }

    public void speakerOn(View view) {
        Log.v("PlivoOutbound", "Speaker on...");
        myAudioManager = (AudioManager) getSystemService(Context.AUDIO_SERVICE);
        if (((ToggleButton) view).isChecked())
            myAudioManager.setSpeakerphoneOn(true);
        else
            myAudioManager.setSpeakerphoneOn(false);

    }

    public void onLogin() {
        Log.v("PlivoOutbound", "Logging in");

    }

    public void onLogout() {

    }

    public void onLoginFailed() {
        Log.v("PlivoOutbound", "Login failed");
    }

    /**
     * This event will be fired when there is new incoming call.
     * 
     * @param incoming
     *            new Incoming call object.
     */
    public void onIncomingCall(Incoming incoming) {

    }

    public void onIncomingCallHangup(Incoming incoming) {

    }

    public void onIncomingCallRejected(Incoming incoming) {

    }

    /**
     * This event will be fired when outgoing call is initiated.
     * 
     * @param outgoing
     */
    public void onOutgoingCall(Outgoing outgoing) {
        Log.v("PlivoOutbound", "Calling...");
        Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
        Button call_button = ((Button) findViewById(R.id.call_btn));
        hangup_button.setEnabled(true);
        hangup_button.setClickable(true);
        call_button.setEnabled(false);
        call_button.setClickable(false);
        Toast.makeText(getApplicationContext(), "Clicked Call",
                Toast.LENGTH_LONG).show();
    }

    public void onOutgoingCallAnswered(Outgoing outgoing) {

    }

    public void onOutgoingCallHangup(Outgoing outgoing) {
        Log.v("PlivoOutbound", "Hang up...");

    }
}
