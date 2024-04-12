// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		The sync offset of an input has changed.)
	*/
	public struct InputAudioSyncOffsetChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("inputAudioSyncOffset")]
		public int InputAudioSyncOffset;

	}
}
