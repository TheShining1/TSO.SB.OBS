// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the audio sync offset of an input.

Note: The audio sync offset can be negative too!)
	*/
	public struct GetInputAudioSyncOffsetRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
	}
	public struct GetInputAudioSyncOffsetResponseData
	{
		[JsonProperty("inputAudioSyncOffset")]
		public double InputAudioSyncOffset;


	}
}
