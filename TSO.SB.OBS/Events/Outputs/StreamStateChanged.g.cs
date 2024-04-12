// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		The state of the stream output has changed.)
	*/
	public struct StreamStateChangedEventData
	{
		[JsonProperty("outputActive")]
		public bool OutputActive;

		[JsonProperty("outputState")]
		public string OutputState;

	}
}
