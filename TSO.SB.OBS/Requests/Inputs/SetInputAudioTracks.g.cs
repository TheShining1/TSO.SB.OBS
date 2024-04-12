// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Sets the enable state of audio tracks of an input.)
	*/
	public struct SetInputAudioTracksRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("inputAudioTracks")]
		public InputAudioTracks InputAudioTracks;
	}
	public struct SetInputAudioTracksResponseData
	{

	}
}
