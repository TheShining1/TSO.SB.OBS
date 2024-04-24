// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Sets the settings of an input.)
	*/
	public struct SetInputSettingsRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("inputSettings")]
		public Dictionary<string,object> InputSettings;
		[JsonProperty("overlay", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Overlay;
	}
	public struct SetInputSettingsResponseData
	{

	}
}
