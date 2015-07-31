package com.plivo.example.outbound;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.media.AudioManager;
import android.net.Uri;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import android.widget.ToggleButton;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;

/**
 * Created by lijo on 29/7/15.
 */
public class Outgoing_Call extends Activity {
    public final static String EXTRA_MESSAGE = "com.plivo.example.MESSAGE";
    public static String PHONE_NUMBER = "";

    AudioManager myAudioManager;
    // Edit the variables below with your Plivo endpoint username and password

    Endpoint endpoint = DataHolder.getEndpoint();
    Outgoing outgoing = new Outgoing(endpoint);
    private EditText number;
    private Button hangup_button;
    private Button call_button;
    private ToggleButton mute_button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_outgoing);
        number = (EditText) findViewById(R.id.number);
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

    public void callNow(View view) {
        // Log into plivo cloud
        //Map
        outgoing = endpoint.createOutgoingCall();
        Log.v("PlivoOutbound", "Create outbound call object");
        PHONE_NUMBER = number.getText().toString();
        Log.v("PlivoOutbound", PHONE_NUMBER);
        call_button = ((Button) findViewById(R.id.call_btn));
        call_button.setEnabled(false);
        call_button.setClickable(false);
        outgoing.call(PHONE_NUMBER);


        //new APICall().execute(new String[]{temp,"+917353659758",to,"aksfkahdf"});


    }

    public void onBackPressed() {
        moveTaskToBack(true);
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
                                    new String[]{
                                            ContactsContract.CommonDataKinds.Phone.NUMBER,
                                            ContactsContract.CommonDataKinds.Phone.TYPE},
                                    null, null, null);

                    if (c != null && c.moveToFirst()) {
                        String _num = CallHelper.helpCall(c.getString(0));
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
        hangup_button = ((Button) findViewById(R.id.hangup_btn));
        call_button = ((Button) findViewById(R.id.call_btn));
        mute_button = ((ToggleButton) findViewById(R.id.muteBtn));

        hangup_button.setEnabled(false);
        hangup_button.setClickable(false);
        call_button.setEnabled(true);
        call_button.setClickable(true);
        mute_button.setChecked(false);
        mute_button.setClickable(false);

    }

    public void speakerOn(View view) {
        myAudioManager = (AudioManager) getSystemService(Context.AUDIO_SERVICE);
        Log.v("PlivoOutbound", "Speaker btn pressed...");
        if (((ToggleButton) view).isChecked())
            myAudioManager.setSpeakerphoneOn(true);
        else
            myAudioManager.setSpeakerphoneOn(false);

    }

    public void muteOn(View view) {
        if (((ToggleButton) view).isChecked()) {
            Log.v("PlivoPhone", "Mute");
            outgoing.mute();
        } else {
            Log.v("PlivoPhone", "Unmute");
            outgoing.unmute();
        }
    }
}
