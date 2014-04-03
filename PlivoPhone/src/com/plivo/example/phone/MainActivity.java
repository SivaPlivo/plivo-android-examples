package com.plivo.example.phone;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.EditText;

import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.EventListener;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;


public class MainActivity extends Activity implements EventListener {
	
	public final static String EXTRA_MESSAGE = "com.plivo.example.MESSAGE";
	Endpoint endpoint = new Endpoint(true, this);

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	public void loginEndpoint(View view) {
	    // Log into plivo cloud
		EditText usernameText = (EditText) findViewById(R.id.username);
		EditText passwordText = (EditText) findViewById(R.id.password);

		String username = usernameText.getText().toString();
		String password = passwordText.getText().toString();
		
		endpoint.login(username, password);	
		
		//endpoint.login("android140326225726", "kunal123");
	}
	
	public void onLogin() {
		
		Log.v("PlivoPhone", "logging in");
		Intent intent = new Intent(this, LoginActivity.class);
		String message = "Login Success";
		
		intent.putExtra(EXTRA_MESSAGE, message);
		startActivity(intent);
		
	}
	
	public void onLogout() {
		
	}
	public void onLoginFailed() {
		
		Log.v("PlivoPhone", "login failed");
		Intent intent = new Intent(this, LoginActivity.class);
		String message = "Login Failed";
		
		intent.putExtra(EXTRA_MESSAGE, message);
		startActivity(intent);
		
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
		
	}
	
	public void onOutgoingCallAnswered(Outgoing outgoing) {
		
	}
	
	public void onOutgoingCallHangup(Outgoing outgoing) {
		
	}
}

