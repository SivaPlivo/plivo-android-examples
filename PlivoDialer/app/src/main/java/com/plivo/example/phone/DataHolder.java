package com.plivo.example.phone;

import com.plivo.endpoint.Endpoint;

/**
 * Created by ramyaraghu on 11/20/15.
 */
public class DataHolder {
    private static Endpoint endpoint;
    public static Endpoint getData() {return endpoint;}
    public static void setData(Endpoint end) {endpoint = end;}
}
