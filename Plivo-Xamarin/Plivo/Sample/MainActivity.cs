using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;
using Com.Plivo.Endpoint;

namespace Sample
{
	[Activity (Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, IEventListener
	{
		public static string PLIVO_USERNAME= ""; //add Plivo endpoint
		public static string PLIVO_PASSWORD = ""; //add Plivo endpoint password

		private Endpoint endpoint;
		public Outgoing outgoing;
		private Incoming incoming;
		public TextView text;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			text = FindViewById<TextView> (Resource.Id.msg);
			endpoint = Endpoint.NewInstance(true, this);

			endpoint.Login(PLIVO_USERNAME, PLIVO_PASSWORD);
			DataHolder.setEndpoint(endpoint);
		
		}

		public void OnLogin() {
			Log.Debug("PlivoOutbound", "Logged in");
			var intent = new Intent (this, typeof(Outgoing_Call));
			StartActivity (intent);

		}

		public void OnLogout() {

		}

		public void OnLoginFailed() {
			Log.Debug("PlivoOutbound", "Login failed");
			RunOnUiThread ( () =>{
				text.Text = "Login Failed";

			});
		}

		/**
    * This event will be fired when there is new incoming call.
    * 
    * @param incoming
    *            new Incoming call object.
    */
		public void OnIncomingCall(Incoming incoming) {
			this.incoming = incoming;
			Log.Debug("PlivoInbound", "Incoming Call...");
			DataHolder.setIncoming (this.incoming);
			var intent = new Intent (this, typeof(Incoming_Call));
			StartActivity (intent);

		}

		public void OnIncomingCallHangup(Incoming incoming) {
			var intent = new Intent (this, typeof(Outgoing_Call));
			StartActivity (intent);
		}

		public void OnIncomingCallRejected(Incoming incoming) {
			var intent = new Intent (this, typeof(Outgoing_Call));
			StartActivity (intent);
		}

		/**
    * This event will be fired when outgoing call is initiated.
    * 
    * @param outgoing
    */
		public void OnOutgoingCall(Outgoing outgoing) {
			Log.Debug("PlivoOutbound", "Calling...");

		}

		public void OnOutgoingCallAnswered(Outgoing outgoing) {
			
		}

		public void OnOutgoingCallHangup(Outgoing outgoing) {
			Log.Debug("PlivoOutbound", "Hang up...");
			var intent = new Intent (this, typeof(Outgoing_Call));
			StartActivity (intent);
		}
		public void OnOutgoingCallRejected(Outgoing outgoing) {
			Log.Debug("PlivoOutbound", "Hang up...");
			var intent = new Intent (this, typeof(Outgoing_Call));
			StartActivity (intent);
		}
		public void OnOutgoingCallInvalid(Outgoing outgoing) {
			Log.Debug("PlivoOutbound", "Hang up...");
			var intent = new Intent (this, typeof(Outgoing_Call));
			StartActivity (intent);
		}
	}
}

