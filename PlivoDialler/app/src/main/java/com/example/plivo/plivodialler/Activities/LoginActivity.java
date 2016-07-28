package com.example.plivo.plivodialler.Activities;

import android.app.ProgressDialog;
import android.content.Intent;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.plivo.plivodialler.Utils.CommManager;
import com.example.plivo.plivodialler.R;

public class LoginActivity extends AppCompatActivity {

    Intent intent;

    CommManager mCommManager;

    EditText getUsername, getPassword;
    Button bLogin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        getUsername = (EditText) findViewById(R.id.endpointUsername);
        getPassword = (EditText) findViewById(R.id.endpointPassword);
        bLogin = (Button) findViewById(R.id.bLogin);

        mCommManager = CommManager.getInstance(this);

        final ProgressDialog pDialog = new ProgressDialog(LoginActivity.this);
        pDialog.setMessage("Logging In...");
        //pDialog.show();

        final Thread showDialog = new Thread(new Runnable() {
            @Override
            public void run() {
                LoginActivity.this.runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        pDialog.show();
                    }
                });
            }
        });

        bLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String username = getUsername.getText().toString();
                String password = getPassword.getText().toString();
                //mCommManager.loginEndpoint(username, password);
                mCommManager.loginEndpoint(username, password);
                showDialog.start();
                while(mCommManager.getLoginStatus() == null){

                }
                pDialog.dismiss();

                if (mCommManager.getLoginStatus().equals("success")){
                    intent = new Intent(LoginActivity.this, DiallerActivity.class);
                    startActivity(intent);
                    finish();
                }else{
                    getUsername.setText(null);
                    getUsername.setHint("Login Failed");
                }
            }
        });
    }
}
