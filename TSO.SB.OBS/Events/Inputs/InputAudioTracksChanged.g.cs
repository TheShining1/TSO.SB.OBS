// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		The audio tracks of an input have changed.)
	*/
	public struct InputAudioTracksChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("inputAudioTracks")]
		public InputAudioTracks InputAudioTracks;

	}
}
