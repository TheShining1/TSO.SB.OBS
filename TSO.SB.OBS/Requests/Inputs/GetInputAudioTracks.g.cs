// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the enable state of all audio tracks of an input.)
	*/
	public struct GetInputAudioTracksRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
	}
	public struct GetInputAudioTracksResponseData
	{
		[JsonProperty("inputAudioTracks")]
		public InputAudioTracks InputAudioTracks;


	}
}
