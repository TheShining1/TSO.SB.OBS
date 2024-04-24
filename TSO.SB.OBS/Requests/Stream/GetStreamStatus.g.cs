// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Stream
{
	/*
		Gets the status of the stream output.)
	*/
	public struct GetStreamStatusRequestData
	{
	}
	public struct GetStreamStatusResponseData
	{
		[JsonProperty("outputActive")]
		public bool OutputActive;

		[JsonProperty("outputReconnecting")]
		public bool OutputReconnecting;

		[JsonProperty("outputTimecode")]
		public string OutputTimecode;

		[JsonProperty("outputDuration")]
		public double OutputDuration;

		[JsonProperty("outputCongestion")]
		public double OutputCongestion;

		[JsonProperty("outputBytes")]
		public double OutputBytes;

		[JsonProperty("outputSkippedFrames")]
		public double OutputSkippedFrames;

		[JsonProperty("outputTotalFrames")]
		public double OutputTotalFrames;


	}
}
