// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		Gets the status of an output.)
	*/
	public struct GetOutputStatusRequestData
	{
		[JsonProperty("outputName")]
		public string OutputName;
	}
	public struct GetOutputStatusResponseData
	{
		[JsonProperty("outputActive")]
		public bool OutputActive;

		[JsonProperty("outputReconnecting")]
		public bool OutputReconnecting;

		[JsonProperty("outputTimecode")]
		public string OutputTimecode;

		[JsonProperty("outputDuration")]
		public int OutputDuration;

		[JsonProperty("outputCongestion")]
		public int OutputCongestion;

		[JsonProperty("outputBytes")]
		public int OutputBytes;

		[JsonProperty("outputSkippedFrames")]
		public int OutputSkippedFrames;

		[JsonProperty("outputTotalFrames")]
		public int OutputTotalFrames;


	}
}
