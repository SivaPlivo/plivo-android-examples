package com.example.plivo.plivodialler.Adapters;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.plivo.plivodialler.R;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Map;
import java.util.Set;

/**
 * Created by plivo on 24/05/16.
 */
public class ContactsAdapter extends BaseAdapter {

    Context mContext;
    Activity activity;
    LayoutInflater inflater = null;

    Map<String, String> contactList;
    ArrayList<String> contactNameList;

    public ContactsAdapter(Activity activity, Map<String, String> contactList){
        this.contactList = contactList;
        this.activity = activity;
        this.inflater = (LayoutInflater)activity.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        contactNameList = getContactsFromHash(contactList);
    }

    @Override
    public int getCount() {
        return contactList.size();
    }

    @Override
    public Object getItem(int i) {
        return contactList.get(contactNameList.get(i));
    }

    @Override
    public long getItemId(int i) {
        return i;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {
        View vi = view;
        if(view == null) {
            vi = inflater.inflate(R.layout.contact_list_row, null);
        }

        TextView contactName = (TextView) vi.findViewById(R.id.contactName);
        TextView contactNumber = (TextView) vi.findViewById(R.id.contactNumber);

        contactName.setText(contactNameList.get(i));
        contactNumber.setText(contactList.get(contactNameList.get(i)));

        return vi;
    }

    public ArrayList<String> getContactsFromHash(Map<String, String> contactList){
        ArrayList<String> contactNamesList = new ArrayList<>();
        Set<String> keySet = contactList.keySet();
        Iterator<String> keyIterator = keySet.iterator();
        while(keyIterator.hasNext()){
            contactNamesList.add(keyIterator.next());
        }
        return contactNamesList;
    }
}
