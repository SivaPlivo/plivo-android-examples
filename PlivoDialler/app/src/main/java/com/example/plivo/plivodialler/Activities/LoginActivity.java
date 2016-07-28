package com.example.plivo.plivodialler.Activities;

import android.app.ProgressDialog;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.plivo.plivodialler.Utils.AppConstants;
import com.example.plivo.plivodialler.Utils.CommManager;
import com.example.plivo.plivodialler.R;

public class LoginActivity extends AppCompatActivity {

    Intent intent;

    CommManager mCommManager;


    String username, password;
    EditText getUsername, getPassword;
    TextView errorText;
    Button bLogin;

    SharedPreferences loginPref;
    SharedPreferences.Editor prefEditor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        loginPref = getSharedPreferences(AppConstants.PREF_Name, 0);
        prefEditor = loginPref.edit();
        username = loginPref.getString(AppConstants.PREF_UserName, null);
        password = loginPref.getString(AppConstants.PREF_Password, null);

        getUsername = (EditText) findViewById(R.id.endpointUsername);
        getPassword = (EditText) findViewById(R.id.endpointPassword);
        errorText = (TextView) findViewById(R.id.tvError);
        errorText.setVisibility(View.GONE);
        bLogin = (Button) findViewById(R.id.bLogin);

        if (username != null && password != null){
            getUsername.setText(username);
            getPassword.setText(password);
        }

        mCommManager = CommManager.getInstance(this);
        //pDialog.show();

        bLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String new_username = getUsername.getText().toString();
                String new_password = getPassword.getText().toString();
                mCommManager.loginEndpoint(new_username, new_password);

                while(mCommManager.getLoginStatus() == null){

                }

                if (mCommManager.getLoginStatus().equals("success")){
                    prefEditor.putString(AppConstants.PREF_UserName, new_username);
                    prefEditor.putString(AppConstants.PREF_Password, new_password);
                    prefEditor.commit();
                    intent = new Intent(LoginActivity.this, DiallerActivity.class);
                    startActivity(intent);
                    finish();
                }else{
                    errorText.setVisibility(View.VISIBLE);
                }
            }
        });
    }
}
