// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		A high-volume event providing volume levels of all active inputs every 50 milliseconds.)
	*/
	public struct InputVolumeMetersEventData
	{
		[JsonProperty("inputs")]
		public Input[] Inputs;

	}
}
