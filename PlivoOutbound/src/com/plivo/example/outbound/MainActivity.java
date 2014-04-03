package com.plivo.example.outbound;

import android.os.Bundle;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;

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
	public final static String PHONE_NUMBER = "";
	
	Endpoint endpoint = new Endpoint(true, this);
	Outgoing outgoing = new Outgoing(endpoint);
	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		
		Log.v("PlivoOutbound", "Trying to log in");
		endpoint.login(PLIVO_USERNAME, PLIVO_PASSWORD);
		
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
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
    	outgoing.call(PHONE_NUMBER);
		
	}
	
	public void hangupNow(View view) {
		Log.v("PlivoOutbound", "Hanging up...");
		outgoing.hangup();
		Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
		Button call_button = ((Button)findViewById(R.id.call_btn));
		hangup_button.setEnabled(false);
		hangup_button.setClickable(false);
		
		call_button.setEnabled(true);
		call_button.setClickable(true);
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
	 * @param incoming new Incoming call object.
	 */
	public void onIncomingCall(Incoming incoming) {
		
	}
	public void onIncomingCallHangup(Incoming incoming) {
		
	}
	public void onIncomingCallRejected(Incoming incoming) {
		
	}
	
	/**
	 * This event will be fired when outgoing call is initiated.
	 * @param outgoing
	 */
	public void onOutgoingCall(Outgoing outgoing) {
		Log.v("PlivoOutbound", "Calling...");
		Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
		Button call_button = ((Button)findViewById(R.id.call_btn));
		hangup_button.setEnabled(true);
		hangup_button.setClickable(true);
		call_button.setEnabled(false);
		call_button.setClickable(false);
	}
	
	public void onOutgoingCallAnswered(Outgoing outgoing) {
		
	}
	
	public void onOutgoingCallHangup(Outgoing outgoing) {
		
	}
}
