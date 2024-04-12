// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Sets the value of a "slot" from the selected persistent data realm.)
	*/
	public struct SetPersistentDataRequestData
	{
		[JsonProperty("realm")]
		public string Realm;
		[JsonProperty("slotName")]
		public string SlotName;
		[JsonProperty("slotValue")]
		public object SlotValue;
	}
	public struct SetPersistentDataResponseData
	{

	}
}
