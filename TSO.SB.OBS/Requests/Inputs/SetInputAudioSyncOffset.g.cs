// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Sets the audio sync offset of an input.)
	*/
	public struct SetInputAudioSyncOffsetRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("inputAudioSyncOffset")]
		public double InputAudioSyncOffset;
	}
	public struct SetInputAudioSyncOffsetResponseData
	{

	}
}
