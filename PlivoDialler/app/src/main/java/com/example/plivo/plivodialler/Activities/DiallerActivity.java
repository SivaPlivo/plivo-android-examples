package com.example.plivo.plivodialler.Activities;

import android.database.Cursor;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.provider.Settings;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ListView;

import com.example.plivo.plivodialler.Adapters.ContactsAdapter;
import com.example.plivo.plivodialler.Utils.CommManager;
import com.example.plivo.plivodialler.R;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.TreeMap;

public class DiallerActivity extends AppCompatActivity {

    CommManager mCommManager;

    EditText phoneNumber;
    ListView showContacts;

    Map<String, String> contactList;
    ArrayList<String> keyIterator;
    ContactsAdapter mAdapter;
    ImageButton ibCall;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dialler);

        mCommManager = CommManager.getInstance(this);

        phoneNumber = (EditText) findViewById(R.id.phoneNumber);
        showContacts = (ListView) findViewById(R.id.contactList);
        ibCall = (ImageButton) findViewById(R.id.ibCall);

        phoneNumber.setText(null);

        contactList = getContacts();
        keyIterator = getKeyList(contactList);

        mAdapter = new ContactsAdapter(this, contactList);
        showContacts.setAdapter(mAdapter);
        showContacts.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                String phoneNumberString = processPhoneNumber(contactList.get(keyIterator.get(i)));
                phoneNumber.setText(phoneNumberString);
            }
        });

        ibCall.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (phoneNumber.getText() != null){
                    mCommManager.makeOutgoingCall(phoneNumber.getText().toString());
                }
            }
        });

    }

    @Override
    public void onBackPressed() {
        super.onBackPressed();
        mCommManager.logoutEndpoint();
    }

    public Map<String, String> getContacts(){

        Map<String, String> contactListMap = new HashMap<>();

        Cursor phones = getContentResolver().query(ContactsContract.CommonDataKinds.Phone.CONTENT_URI, null,null,null, null);
        while (phones.moveToNext())
        {
            String name=phones.getString(phones.getColumnIndex(ContactsContract.CommonDataKinds.Phone.DISPLAY_NAME));
            String phoneNumber = phones.getString(phones.getColumnIndex(ContactsContract.CommonDataKinds.Phone.NUMBER));

            contactListMap.put(name, phoneNumber);
        }
        phones.close();

        contactListMap = new TreeMap<String, String>(contactListMap);

        return contactListMap;
    }

    public ArrayList<String> getKeyList(Map<String, String> contactList){
        Iterator<String> tempKeyIterator = contactList.keySet().iterator();
        ArrayList<String> keyList = new ArrayList<>();

        while (tempKeyIterator.hasNext()){
            keyList.add(tempKeyIterator.next());
        }
        return keyList;
    }

    public String processPhoneNumber(String phoneNumber){
        String tempNumber = phoneNumber;
        if (tempNumber.startsWith("+")){
            tempNumber = tempNumber.substring(1);
        }
        return tempNumber;
    }
}
