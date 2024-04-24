// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		The audio balance value of an input has changed.)
	*/
	public struct InputAudioBalanceChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("inputAudioBalance")]
		public double InputAudioBalance;

	}
}
