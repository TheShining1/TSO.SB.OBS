// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Gets the value of a "slot" from the selected persistent data realm.)
	*/
	public struct GetPersistentDataRequestData
	{
		[JsonProperty("realm")]
		public string Realm;
		[JsonProperty("slotName")]
		public string SlotName;
	}
	public struct GetPersistentDataResponseData
	{
		[JsonProperty("slotValue")]
		public object SlotValue;


	}
}
