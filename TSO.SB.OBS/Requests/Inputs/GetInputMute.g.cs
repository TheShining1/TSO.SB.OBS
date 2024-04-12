// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the audio mute state of an input.)
	*/
	public struct GetInputMuteRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
	}
	public struct GetInputMuteResponseData
	{
		[JsonProperty("inputMuted")]
		public bool InputMuted;


	}
}
