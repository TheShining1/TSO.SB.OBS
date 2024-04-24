// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Record
{
	/*
		Gets the status of the record output.)
	*/
	public struct GetRecordStatusRequestData
	{
	}
	public struct GetRecordStatusResponseData
	{
		[JsonProperty("outputActive")]
		public bool OutputActive;

		[JsonProperty("outputPaused")]
		public bool OutputPaused;

		[JsonProperty("outputTimecode")]
		public string OutputTimecode;

		[JsonProperty("outputDuration")]
		public double OutputDuration;

		[JsonProperty("outputBytes")]
		public double OutputBytes;


	}
}
