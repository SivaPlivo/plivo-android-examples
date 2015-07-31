using System;
using Com.Plivo.Endpoint;


namespace Sample
{
	public class DataHolder
	{
		private static Endpoint endpoint ;
		private static Outgoing outgoing;
		private static Incoming incoming;
		public static Endpoint getEndpoint() {
			return endpoint;
		}

		public static void setEndpoint(Endpoint endpt) {
			endpoint = endpt;
		}

		public static Outgoing getOutgoing(){
			return outgoing;
		}

		public static void setOutgoing(Outgoing outgoing) {
			DataHolder.outgoing = outgoing;
		}

		public static Incoming getIncoming(){
			return incoming;
		}

		public static void setIncoming(Incoming incoming) {
			DataHolder.incoming = incoming;
		}
	}
}

