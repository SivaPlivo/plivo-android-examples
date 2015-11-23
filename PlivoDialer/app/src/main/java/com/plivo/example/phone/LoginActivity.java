package com.plivo.example.phone;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;

public class LoginActivity extends Activity {
	public static String PHONE_NUMBER = "";
	private EditText number;
	Endpoint end = DataHolder.getData();
	Outgoing outgoing = new Outgoing(end);
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		Intent intent = getIntent();
		Log.v("PlivoPhone", end.toString());
	    setContentView(R.layout.activity_login_success);
		number = (EditText) findViewById(R.id.number);
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.login_success, menu);
		return true;
	}

	public void callNow(View view) {
		// Log into plivo cloud
		Log.v("PlivoPhone", outgoing.toString());
		outgoing = end.createOutgoingCall();
		Log.v("PlivoPhone", "Create outbound call object");
		PHONE_NUMBER = number.getText().toString();
		Log.v("PlivoPhone", PHONE_NUMBER);
		Button hangup_button = ((Button) findViewById(R.id.hangup_btn));
		Button call_button = ((Button) findViewById(R.id.call_btn));
		hangup_button.setEnabled(true);
		hangup_button.setClickable(true);
		call_button.setEnabled(false);
		call_button.setClickable(false);
		outgoing.call(PHONE_NUMBER);
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

	public void onLogin() { }
	public void onLogout() { }
	public void onLoginFailed() { }

	/**
	 * This event will be fired when there is new incoming call.
	 * @param incoming new Incoming call object.
	 */
	public void onIncomingCall(Incoming incoming) { }
	public void onIncomingCallHangup(Incoming incoming) { }
	public void onIncomingCallRejected(Incoming incoming) { }

	/**
	 * This event will be fired when outgoing call is initiated.
	 * @param outgoing
	 */
	public void onOutgoingCall(Outgoing outgoing) { }

	public void onOutgoingCallAnswered(Outgoing outgoing) { }

	public void onOutgoingCallHangup(Outgoing outgoing) { }

	public void onOutgoingCallInvalid(Outgoing outgoing) { }

	public void onOutgoingCallRejected(Outgoing outgoing) { }
}
