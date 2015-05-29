package com.plivo.example.inbound;

import android.content.Context;
import android.media.AudioManager;
import android.os.Bundle;
import android.app.Activity;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
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

	
	Endpoint endpoint = new Endpoint(true, this);
	private Incoming incoming;
	private AudioManager myAudioManager;
	

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		
		Log.v("PlivoInbound", "Trying to log in");
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
	
	public void hangupNow(View view) {
		Log.v("PlivoInbound", "Hanging up...");
		incoming.hangup();
		Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
		Button answer_button = ((Button)findViewById(R.id.answer_btn));
		hangup_button.setEnabled(false);
		hangup_button.setClickable(false);
		
		answer_button.setEnabled(false);
		answer_button.setClickable(false);
	}
	
	public void answerNow(View view) {
		Log.v("PlivoInbound", "Answering");
		incoming.answer();
		Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
		Button answer_button = ((Button)findViewById(R.id.answer_btn));
		hangup_button.setEnabled(false);
		hangup_button.setClickable(false);
		
		answer_button.setEnabled(false);
		answer_button.setClickable(false);
	}
	
	public void onLogin() {
		Log.v("PlivoInbound", "Logging in");
	}
	
	public void onLogout() {
		
	}
	
	public void onLoginFailed() {
		Log.v("PlivoInbound", "Login failed");
	}
	
	/**
	 * This event will be fired when there is new incoming call.
	 * @param incoming new Incoming call object.
	 */
	public void onIncomingCall(Incoming incoming) {
		this.incoming = incoming;
		
		Log.v("PlivoInbound", "Inbound Call...");
		
		runOnUiThread(new Runnable() {
			public void run() {
				Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
				Button answer_button = ((Button)findViewById(R.id.answer_btn));
				hangup_button.setEnabled(true);
				hangup_button.setClickable(true);
				answer_button.setEnabled(true);
				answer_button.setClickable(true);
			}
		});
	}
	
	public void onIncomingCallHangup(Incoming incoming) {
		Log.v("PlivoInbound", "Call hanging up");
		Button hangup_button = ((Button)findViewById(R.id.hangup_btn));
		Button answer_button = ((Button)findViewById(R.id.answer_btn));
		hangup_button.setEnabled(false);
		hangup_button.setClickable(false);
		answer_button.setEnabled(false);
		answer_button.setClickable(false);	
	}
	
	public void speakerOn(View view) {
	       Log.v("PlivoOutbound", "Speaker on...");
	       myAudioManager = (AudioManager)getSystemService(Context.AUDIO_SERVICE);
	       if (((ToggleButton) view).isChecked())
	           myAudioManager.setSpeakerphoneOn(true);
	       else
	           myAudioManager.setSpeakerphoneOn(false);
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
