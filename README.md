## Android Sample Apps

Collection of apps using the Plivo Android SDK.

### Get Started

1. Clone this repo

2. Launch Eclipse

3. Select File -> New -> Other 

4. Choose 'Android Project From Existing Code' and navigate to the `plivo-android-examples` folder


#### PlivoPhone

A sample application to demonstrate basic phone registration.

#####Pre-requisites

1. Plivo Account
2. Create an endpoint with a username and a password.

#####Get started

1. Launch the application from eclipse.
2. Enter the username and password of your endpoint when prompted for.

####PlivoOutbound

A sample application to demonstrate outbound call to a mobile or a landline phone.

#####Pre-requisites

1. Plivo Account
2. Create an endpoint with a username and a password.


#####Get started

1. Load the application in eclipse.
2. Edit the source file `MainActivity.java`. Assign your endpoint username and password to the respective variables.

```java
    public final static String PLIVO_USERNAME = "";
    public final static String PLIVO_PASSWORD = "";
```

3. Assign the mobile or the landline number you want to call to the `PLIVO_NUMBER` variable.

```java
    public final static String PHONE_NUMBER = "";
```

4. Launch the application from eclipse. And hit the call button.


#### PlivoInbound

A sample application to demonstrate inbound calls.

#####Pre-requisites

1. Plivo Account
2. Create a endpoint with a username and a password for your android application.
3. Create another endpoint, this will be used to make the call to the application set up on android.


#####Get started

1. Load the application in eclipse.
2. Edit the source file `MainActivity.java`. Assign your endpoint username and password to the respective variables.

```java
    public final static String PLIVO_USERNAME = "";
    public final static String PLIVO_PASSWORD = "";
```

3. Launch the application from eclipse. 

4. Use a soft phone like X-Lite or telephone and setup your account with the second endpoint. 

5. Make a call to the endpoint setup with the Android application.



