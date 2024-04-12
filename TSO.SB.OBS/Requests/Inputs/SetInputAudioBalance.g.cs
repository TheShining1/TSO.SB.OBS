// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Sets the audio balance of an input.)
	*/
	public struct SetInputAudioBalanceRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("inputAudioBalance")]
		public int InputAudioBalance;
	}
	public struct SetInputAudioBalanceResponseData
	{

	}
}
