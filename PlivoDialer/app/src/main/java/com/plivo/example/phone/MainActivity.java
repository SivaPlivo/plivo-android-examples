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
import com.plivo.endpoint.EventListener;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;


public class MainActivity extends Activity implements EventListener {
    Endpoint endpoint = Endpoint.newInstance(true, this);

	@Override
	protected void onCreate(Bundle savedInstanceState) {
        Log.v("PlivoPhone", endpoint.toString());
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
	}
	
	public void onLogin() {
		Log.v("PlivoPhone", "logged in");
		Intent intent = new Intent(this, LoginActivity.class);
        DataHolder.setData(endpoint);
		startActivity(intent);
	}
	
	public void onLogout() { }

    public void onLoginFailed() {
		Log.v("PlivoPhone", "login failed");
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
        Log.v("PlivoPhone", "Calling...");
	}

    public void onOutgoingCallAnswered(Outgoing outgoing) {
        Log.v("PlivoPhone", "Outgoing call answered...");
    }

    public void onOutgoingCallHangup(Outgoing outgoing) {
        Log.v("PlivoPhone", "Hang up...");
    }

    public void onOutgoingCallInvalid(Outgoing outgoing) {
        Log.v("PlivoPhone", "Invalid...");
    }

    public void onOutgoingCallRejected(Outgoing outgoing) {
        Log.v("PlivoPhone", "Call rejected...");
    }
}

