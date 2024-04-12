// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		An event has been emitted from a vendor.

A vendor is a unique name registered by a third-party plugin or script, which allows for custom requests and events to be added to obs-websocket.
If a plugin or script implements vendor requests or events, documentation is expected to be provided with them.)
	*/
	public struct VendorEventEventData
	{
		[JsonProperty("vendorName")]
		public string VendorName;

		[JsonProperty("eventType")]
		public string EventType;

		[JsonProperty("eventData")]
		public Dictionary<string,object> EventData;

	}
}
