// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		The state of the replay buffer output has changed.)
	*/
	public struct ReplayBufferStateChangedEventData
	{
		[JsonProperty("outputActive")]
		public bool OutputActive;

		[JsonProperty("outputState")]
		public string OutputState;

	}
}
