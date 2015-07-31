
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
	[Activity (Label = "Incoming_Call")]			
	public class Incoming_Call : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			SetContentView (Resource.Layout.Activity_incoming);


			Incoming incoming = DataHolder.getIncoming ();

			Button _answer = FindViewById<Button> (Resource.Id.myButton);
			Button _hangup = FindViewById<Button> (Resource.Id.hangup);

			_answer.Click += delegate {
				Log.Debug("PlivoInbound", "Answering...");        
				_answer.Enabled= false;
				_answer.Clickable=false;

				incoming.Answer();
		
			};



			_hangup.Click += delegate {
				Log.Debug("PlivoInbound", "Hanging up...");        
				incoming.Hangup();
				var intent = new Intent (this, typeof(Outgoing_Call));
				StartActivity (intent);
			};


		}
		public override void OnBackPressed() {
			// Disable going back to the MainActivity
			MoveTaskToBack(true);
		}
	}
}

