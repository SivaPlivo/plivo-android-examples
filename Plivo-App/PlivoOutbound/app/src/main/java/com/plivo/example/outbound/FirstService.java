package com.plivo.example.outbound;

import android.content.Context;
import android.content.Intent;
import android.media.AudioManager;
import android.os.IBinder;
import android.app.Service;
import android.util.Log;
import android.widget.Button;
import android.widget.Toast;
import android.widget.ToggleButton;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.EventListener;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;

/**
 * Created by lijo on 22/6/15.
 */
public class FirstService extends Service implements EventListener {

    public final static String PLIVO_USERNAME = "sammytest1150519064935"; //  sammytest1150519064935
    public final static String PLIVO_PASSWORD = "thanks123";
    private AudioManager audioManager;
    Endpoint endpoint = Endpoint.newInstance(false, this);
    Incoming incoming;

    @Override
    public IBinder onBind(Intent arg0) {
        return null;
    }



    @Override
    public void onCreate() {
        super.onCreate();

    }

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        //TODO do something useful
        Log.v("PlivoOutbound", "Trying to log in");

        endpoint.login(PLIVO_USERNAME, PLIVO_PASSWORD);
        DataHolder.setEndpoint(endpoint);
        return Service.START_STICKY;
    }

    public void onLogin() {
        Log.v("PlivoOutbound", "Logged in");

    }

    public void onLogout() {
        Log.v("PlivoOutbound", "Logged Out");
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
        Log.v("PlivoOutbound", "Calling before dataholder");
        this.incoming = incoming;
        DataHolder.setIncoming(this.incoming);
        Log.v("PlivoOutbound", "Calling...");
        Intent intent = new Intent(this, Incoming_Call.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
    }

    public void onIncomingCallHangup(Incoming incoming) {
        Log.v("PlivoOutbound", "Calling...");
        Intent intent = new Intent(this, Outgoing_Call.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
    }

    public void onIncomingCallRejected(Incoming incoming) {
        Log.v("PlivoOutbound", "Calling...");
        Intent intent = new Intent(this, Outgoing_Call.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
    }

    /**
     * This event will be fired when outgoing call is initiated.
     *
     * @param outgoing
     */
    public void onOutgoingCall(Outgoing outgoing) {

    }


    public void onOutgoingCallAnswered(Outgoing outgoing) {


    }

    public void onOutgoingCallRejected(Outgoing outgoing) {
        Log.v("PlivoPhone", "Call Ended");
        Intent intent = new Intent(this, Outgoing_Call.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
    }

    public void onOutgoingCallHangup(Outgoing outgoing) {
        Log.v("PlivoPhone", "Call Ended");
        Intent intent = new Intent(this, Outgoing_Call.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
    }

    public void onOutgoingCallInvalid(Outgoing outgoing) {
        Log.v("PlivoOutbound", "Call Invalid...");
        Intent intent = new Intent(this, Outgoing_Call.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
    }
}
