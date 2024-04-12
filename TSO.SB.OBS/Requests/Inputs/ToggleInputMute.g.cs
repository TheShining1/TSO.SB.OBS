// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Toggles the audio mute state of an input.)
	*/
	public struct ToggleInputMuteRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
	}
	public struct ToggleInputMuteResponseData
	{
		[JsonProperty("inputMuted")]
		public bool InputMuted;


	}
}
