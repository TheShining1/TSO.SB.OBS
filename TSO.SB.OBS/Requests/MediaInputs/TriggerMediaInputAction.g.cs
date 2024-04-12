// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.MediaInputs
{
	/*
		Triggers an action on a media input.)
	*/
	public struct TriggerMediaInputActionRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("mediaAction")]
		public string MediaAction;
	}
	public struct TriggerMediaInputActionResponseData
	{

	}
}
