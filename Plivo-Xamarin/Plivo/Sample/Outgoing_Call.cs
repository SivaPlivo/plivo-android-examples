
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Com.Plivo.Endpoint;

namespace Sample
{
	[Activity (Label = "Outgoing_Call")]			
	public class Outgoing_Call : Activity
	{
		public static String PHONE_NUMBER = "919886689752";
		private Endpoint endpoint;
		public Outgoing outgoing;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Activity_outgoing);

			endpoint = DataHolder.getEndpoint();
			outgoing = new Outgoing(endpoint);

			Button _call = FindViewById<Button> (Resource.Id.call_btn);
			EditText _num = FindViewById<EditText> (Resource.Id.number);
			Button _hangup = FindViewById<Button> (Resource.Id.hangup_btn);

			_call.Click += delegate {
				outgoing = endpoint.CreateOutgoingCall();
				Log.Debug("PlivoOutbound", "Create outbound call object");        
				_call.Enabled= false;
				_call.Clickable=false;
				_hangup.Enabled=true;
				_hangup.Clickable=true;
				outgoing.Call(_num.Text);
			};



			_hangup.Click += delegate {
				_call.Enabled= true;
				_call.Clickable=true;
				_hangup.Enabled=false;
				_hangup.Clickable=false;
				outgoing.Hangup();
				Log.Debug("PlivoOutbound", "Hanging up ...");        
			};
		}
		public override void OnBackPressed() {
			// Disable going back to the MainActivity
			MoveTaskToBack(true);
		}
	}
}

