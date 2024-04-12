// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		An input's active state has changed.

When an input is active, it means it's being shown by the program feed.)
	*/
	public struct InputActiveStateChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("videoActive")]
		public bool VideoActive;

	}
}
