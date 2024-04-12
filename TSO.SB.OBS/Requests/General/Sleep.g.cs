// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Sleeps for a time duration or number of frames. Only available in request batches with types `SERIAL_REALTIME` or `SERIAL_FRAME`.)
	*/
	public struct SleepRequestData
	{
		[JsonProperty("sleepMillis", NullValueHandling = NullValueHandling.Ignore)]
		public int SleepMillis;
		[JsonProperty("sleepFrames", NullValueHandling = NullValueHandling.Ignore)]
		public int SleepFrames;
	}
	public struct SleepResponseData
	{

	}
}
