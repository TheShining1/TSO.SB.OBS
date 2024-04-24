// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Gets the info for a specific source filter.)
	*/
	public struct GetSourceFilterRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("filterName")]
		public string FilterName;
	}
	public struct GetSourceFilterResponseData
	{
		[JsonProperty("filterEnabled")]
		public bool FilterEnabled;

		[JsonProperty("filterIndex")]
		public double FilterIndex;

		[JsonProperty("filterKind")]
		public string FilterKind;

		[JsonProperty("filterSettings")]
		public Dictionary<string,object> FilterSettings;


	}
}
