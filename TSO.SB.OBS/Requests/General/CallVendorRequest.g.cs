// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Call a request registered to a vendor.

A vendor is a unique name registered by a third-party plugin or script, which allows for custom requests and events to be added to obs-websocket.
If a plugin or script implements vendor requests or events, documentation is expected to be provided with them.)
	*/
	public struct CallVendorRequestRequestData
	{
		[JsonProperty("vendorName")]
		public string VendorName;
		[JsonProperty("requestType")]
		public string RequestType;
		[JsonProperty("requestData", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string,object> RequestData;
	}
	public struct CallVendorRequestResponseData
	{
		[JsonProperty("vendorName")]
		public string VendorName;

		[JsonProperty("requestType")]
		public string RequestType;

		[JsonProperty("responseData")]
		public Dictionary<string,object> ResponseData;


	}
}
