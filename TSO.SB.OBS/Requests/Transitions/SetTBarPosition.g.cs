// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Sets the position of the TBar.

**Very important note**: This will be deprecated and replaced in a future version of obs-websocket.)
	*/
	public struct SetTBarPositionRequestData
	{
		[JsonProperty("position")]
		public int Position;
		[JsonProperty("release", NullValueHandling = NullValueHandling.Ignore)]
		public bool Release;
	}
	public struct SetTBarPositionResponseData
	{

	}
}
