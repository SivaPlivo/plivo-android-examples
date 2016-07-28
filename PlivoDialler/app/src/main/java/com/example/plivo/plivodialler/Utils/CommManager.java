package com.example.plivo.plivodialler.Utils;

import android.app.Application;
import android.content.Context;
import android.content.Intent;
import android.util.Log;

import com.example.plivo.plivodialler.Activities.DiallerActivity;
import com.example.plivo.plivodialler.Activities.OngoingCall;
import com.plivo.endpoint.Endpoint;
import com.plivo.endpoint.EventListener;
import com.plivo.endpoint.Incoming;
import com.plivo.endpoint.Outgoing;

/**
 * Created by plivo on 26/05/16.
 */

public class CommManager extends Application implements EventListener{

    //Instance of the Singleton Class
    private static CommManager ourInstance = null;

    private Endpoint plivoEndpoint;
    private Incoming plivoIncoming;
    private Outgoing plivoOutgoing;

    private static Context mContext;

    private String callNumber = "";
    Boolean incomingCall = false;
    private static String loginStatus = null;
    private static boolean callLock = false;

    public static CommManager getInstance(Context context) {
        if (ourInstance == null){
            ourInstance = new CommManager();
        }
        mContext = context;
        return ourInstance;
    }

    private CommManager() {
        plivoEndpoint = Endpoint.newInstance(true, this);
        /**/
    }

    public void loginEndpoint(String endpointUsername, String endpointPassword){
        plivoEndpoint.login(endpointUsername, endpointPassword);
    }

    public void logoutEndpoint(){
        if (plivoEndpoint != null) {
            plivoEndpoint.logout();
        }
    }

    public String getLoginStatus(){
        return loginStatus;
    }

    //Methods for Login operations

    @Override
    public void onLoginFailed() {
        loginStatus = "failed";
        Log.e(AppConstants.TAG_AppLog, "Login Failed");
    }

    @Override
    public void onLogout() {
        loginStatus = null;
        Log.e(AppConstants.TAG_AppLog, "Logged Out");
    }

    @Override
    public void onLogin() {
        Log.e(AppConstants.TAG_AppLog, "Logged In");
        loginStatus = "success";
    }


    //Methods for Outgoing Calls

    @Override
    public void onOutgoingCallHangup(Outgoing outgoing) {
        Intent i = new Intent(mContext.getApplicationContext(), DiallerActivity.class);
        mContext.startActivity(i);
        callLock = false;
    }

    @Override
    public void onOutgoingCallAnswered(Outgoing outgoing) {

    }

    @Override
    public void onOutgoingCall(Outgoing outgoing) {
        incomingCall = false;
        callLock = true;
        callNumber = plivoOutgoing.getToContact().split(":")[1].split("@")[0];
        Intent i = new Intent(mContext.getApplicationContext(), OngoingCall.class);
        mContext.startActivity(i);
    }

    public void makeOutgoingCall(String phoneNumber){
        plivoOutgoing = plivoEndpoint.createOutgoingCall();
        plivoOutgoing.call(phoneNumber);
    }

    public void outgoingHangup(){
        plivoOutgoing.hangup();
        callLock = false;
        Intent i = new Intent(mContext.getApplicationContext(), DiallerActivity.class);
        mContext.startActivity(i);
    }

    public void sendOutgoingDigits(String digit){
        plivoOutgoing.sendDigits(digit);
    }

    //Methods for Incoming Calls

    @Override
    public void onIncomingCallRejected(Incoming incoming) {
        if(!callLock){
            Intent i = new Intent(mContext.getApplicationContext(), DiallerActivity.class);
            mContext.startActivity(i);
        }
    }

    @Override
    public void onIncomingCallHangup(Incoming incoming) {
        Intent i = new Intent(mContext.getApplicationContext(), DiallerActivity.class);
        mContext.startActivity(i);
    }

    @Override
    public void onIncomingCall(Incoming incoming) {
        plivoIncoming = incoming;
        if (!callLock) {
            incomingCall = true;
            callNumber = plivoIncoming.getFromContact().split(":")[1].split("@")[0];
            Intent i = new Intent(mContext.getApplicationContext(), OngoingCall.class);
            mContext.startActivity(i);
        }else{
            plivoIncoming.reject();
        }
    }

    public void incomingAnswer(){
        if (plivoIncoming != null){
            plivoIncoming.answer();
        }
    }

    public void incomingHangup(){
        plivoIncoming.hangup();
    }

    public void incomingReject(){
        if (plivoIncoming != null){
            plivoIncoming.reject();
        }
        Intent i = new Intent(mContext.getApplicationContext(), DiallerActivity.class);
        mContext.startActivity(i);
    }

    public void sendIncomingDigits(String digit){
        plivoIncoming.sendDigits(digit);
    }

    //General Call Operations

    public String getCallerID(){
        return callNumber;
    }

    public void callMute(){
        if (incomingCall){
            plivoIncoming.mute();
        }else{
            plivoOutgoing.mute();
        }
    }

    public void callUnmute(){
        if (incomingCall){
            plivoIncoming.unmute();
        }else{
            plivoOutgoing.unmute();
        }
    }

    public boolean isIncomingCall(){
        return incomingCall;
    }


    @Override
    public void onIncomingDigitNotification(String s) {

    }

    @Override
    public void onOutgoingCallRejected(Outgoing outgoing) {

    }

    @Override
    public void onOutgoingCallInvalid(Outgoing outgoing) {

    }
}
