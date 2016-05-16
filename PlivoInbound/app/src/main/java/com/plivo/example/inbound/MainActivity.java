package com.plivo.example.inbound;

import android.content.IntentFilter;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.os.Handler;
import android.widget.Toast;
import android.os.Bundle;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.app.AlertDialog;
import android.app.Dialog;
import android.content.DialogInterface;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.EventListener;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;


public class MainActivity extends Activity implements EventListener, NetworkStateReceiver.NetworkStateReceiverListener {

    public final static String EXTRA_MESSAGE = "com.plivo.example.MESSAGE";

    // Edit the variables below with your Plivo endpoint username and password
    public final static String PLIVO_USERNAME = "Endpoint Username";
    public final static String PLIVO_PASSWORD = "Endpoint Password";

    Endpoint endpoint;
    //	Endpoint endpoint = Endpoint.newInstance(true, this);
    private Incoming incoming;
    private volatile boolean inBackGround = true;

    private NetworkStateReceiver networkStateReceiver;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        networkStateReceiver = new NetworkStateReceiver(getApplicationContext());
        networkStateReceiver.addListener(this);
        this.registerReceiver(networkStateReceiver, new IntentFilter(android.net.ConnectivityManager.CONNECTIVITY_ACTION));
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    public void hangupNow(View view) {
        Log.i("PlivoInbound", "Hanging up...");
        incoming.hangup();
        Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
        Button answer_button = ((Button) findViewById(R.id.answer_btn));
        hangup_button.setEnabled(false);
        hangup_button.setClickable(false);

        answer_button.setEnabled(false);
        answer_button.setClickable(false);
    }

    public void answerNow(View view) {
        Log.i("PlivoInbound", "Answering");
        incoming.answer();
        Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
        Button answer_button = ((Button) findViewById(R.id.answer_btn));
        hangup_button.setEnabled(true);
        hangup_button.setClickable(true);

        answer_button.setEnabled(false);
        answer_button.setClickable(false);
    }

    public void onLogin() {
        Log.i("onLogin", "onLogin ");

    }


    public void onLogout() {

        Log.i("onLogout", "onLogout ");
    }

    public void onLoginFailed() {
        Log.i("PlivoInbound", "Login failed");
        //endpoint = Endpoint.newInstance(true, this);
    }

    /**
     * This event will be fired when there is new incoming call.
     *
     * @param incoming new Incoming call object.
     */
    public void onIncomingCall(final Incoming incoming) {
        this.incoming = incoming;

        Log.i("PlivoInbound", "Inbound Call...");


        runOnUiThread(new Runnable() {


            public void run() {

                // For alert menu in while getting a incoming call
                Toast.makeText(MainActivity.this, "Incoming call", Toast.LENGTH_LONG).show();
                AlertDialog alertDialog = new AlertDialog.Builder(
                        MainActivity.this).create();

                // Setting Dialog Title
                alertDialog.setTitle("Incoming call");

                // Setting Dialog Message
                alertDialog.setMessage("Pick an Incoming Call Option");

                // Setting Icon to Dialog
                alertDialog.setIcon(R.drawable.incoming);

                alertDialog.setButton(Dialog.BUTTON_POSITIVE, "Accept",
                        new DialogInterface.OnClickListener() {

                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                // TODO Auto-generated method stub
                                incoming.answer();

                                Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
                                hangup_button.setVisibility(View.VISIBLE);
                                hangup_button.setEnabled(true);
                                hangup_button.setClickable(true);
                            }
                        });

                alertDialog.setButton(Dialog.BUTTON_NEUTRAL, "Reject",
                        new DialogInterface.OnClickListener() {

                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                // TODO Auto-generated method stub
                                onIncomingCallHangup(incoming);

                                Toast.makeText(getApplicationContext(), "Call rejected", Toast.LENGTH_LONG).show();
                            }
                        });

                alertDialog.setButton(Dialog.BUTTON_NEGATIVE, "DND",
                        new DialogInterface.OnClickListener() {

                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                // TODO Auto-generated method stub

                                dialog.cancel();

                                Toast.makeText(getApplicationContext(), "DND", Toast.LENGTH_LONG).show();
                            }
                        });

                // Showing Alert Message
                alertDialog.show();


                Button pbutton = alertDialog.getButton(DialogInterface.BUTTON_POSITIVE);
                pbutton.setTextColor(Color.GREEN);
                pbutton.setTextSize(20);
                pbutton.setBackgroundColor(Color.BLACK);

                Button nbutton = alertDialog.getButton(DialogInterface.BUTTON_NEGATIVE);
                nbutton.setTextColor(Color.BLUE);
                nbutton.setBackgroundColor(Color.BLACK);
                nbutton.setTextSize(20);

                Button nubutton = alertDialog.getButton(DialogInterface.BUTTON_NEUTRAL);
                nubutton.setTextColor(Color.RED);
                nubutton.setBackgroundColor(Color.BLACK);
                nubutton.setTextSize(20);
//                Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
//                Button answer_button = ((Button) findViewById(R.id.answer_btn));
//
//                hangup_button.setVisibility(View.VISIBLE);
//                answer_button.setVisibility(View.VISIBLE);
//
//                hangup_button.setEnabled(true);
//                hangup_button.setClickable(true);
//
//                answer_button.setEnabled(true);
//                answer_button.setClickable(true);
//                Toast.makeText(getApplicationContext(), "Incoming Call ->", Toast.LENGTH_LONG).show();

            }
        });
    }

    public void onIncomingCallHangup(Incoming incoming) {
        Log.i("PlivoInbound", "Call hanging up");
        incoming.hangup();
        Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
        Button answer_button = ((Button) findViewById(R.id.answer_btn));
        hangup_button.setEnabled(false);
        hangup_button.setClickable(false);
        answer_button.setEnabled(false);
        answer_button.setClickable(false);
    }

    public void onIncomingCallRejected(Incoming incoming) {

    }

    /**
     * This event will be fired when outgoing call is initiated.
     *
     * @param outgoing
     */
    public void onOutgoingCall(Outgoing outgoing) {

    }

    public void onOutgoingCallInvalid(Outgoing outgoing) {

    }

    public void onOutgoingCallRejected(Outgoing outgoing) {

    }

    public void onOutgoingCallAnswered(Outgoing outgoing) {

    }

    public void onOutgoingCallHangup(Outgoing outgoing) {

    }

    @Override
    public void onPause() {
        super.onPause();
        Log.i("onPause", " called inBackground flag set to true");
        inBackGround = true;
        if (endpoint != null) {
            endpoint.keepAlive();
        }
        new Handler().postDelayed(new Runnable() {
            public void run() {
                try {
                    if (endpoint != null) {
                        endpoint.keepAlive();
                        Log.i("Thread Pause", "keep alive called");
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
                Log.i("onPause", "Thread ending");
            }
        }, 900000L); //15 Min delay


    }

    @Override
    public void onResume() {
        super.onResume();
        inBackGround = false;
        Log.i("onResume", " called inBackground flag set to false");

    }


    @Override
    public void onNetworkAvailable() {
        Log.i("Plivo Inbound", "Network Available");
        endpoint = Endpoint.newInstance(true, this);
        Log.i("Plivo Inbound", "Reregister");
        Log.i("PlivoInbound", "Trying to log in");
        endpoint.login(PLIVO_USERNAME, PLIVO_PASSWORD);
    }

    @Override
    public void onNetworkUnavailable() {
        Log.i("Plivo Inbound", "Network UnAvailable - resetEndpoint");
        if (endpoint != null) {
            endpoint.resetEndpoint();
            endpoint = null;
        }

    }
}