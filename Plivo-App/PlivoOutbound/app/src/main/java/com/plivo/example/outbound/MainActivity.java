package com.plivo.example.outbound;

import android.content.Context;
import android.content.Intent;
import android.content.res.Configuration;
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


public class MainActivity extends Activity {

    public final static String EXTRA_MESSAGE = "com.plivo.example.MESSAGE";
    // Edit the variables below with your Plivo endpoint username and password


    //public static String PHONE_NUMBER = "";
    //private EditText number;
    //AudioManager myAudioManager;

    //Outgoing outgoing = new Outgoing(endpoint);
    //private Button hangup_button;
    //private Button call_button;
    //private ToggleButton mute_button;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        startService(new Intent(this, FirstService.class));


        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Intent intent = new Intent(this, Outgoing_Call.class);
        startActivity(intent);

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

}


