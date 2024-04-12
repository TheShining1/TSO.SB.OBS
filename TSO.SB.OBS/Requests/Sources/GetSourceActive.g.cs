// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Sources
{
	/*
		Gets the active and show state of a source.

**Compatible with inputs and scenes.**)
	*/
	public struct GetSourceActiveRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
	}
	public struct GetSourceActiveResponseData
	{
		[JsonProperty("videoActive")]
		public bool VideoActive;

		[JsonProperty("videoShowing")]
		public bool VideoShowing;


	}
}
