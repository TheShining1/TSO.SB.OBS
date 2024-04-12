// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Broadcasts a `CustomEvent` to all WebSocket clients. Receivers are clients which are identified and subscribed.)
	*/
	public struct BroadcastCustomEventRequestData
	{
		[JsonProperty("eventData")]
		public Dictionary<string,object> EventData;
	}
	public struct BroadcastCustomEventResponseData
	{

	}
}
