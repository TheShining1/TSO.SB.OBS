// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Creates a new filter, adding it to the specified source.)
	*/
	public struct CreateSourceFilterRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("filterName")]
		public string FilterName;
		[JsonProperty("filterKind")]
		public string FilterKind;
		[JsonProperty("filterSettings", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string,object> FilterSettings;
	}
	public struct CreateSourceFilterResponseData
	{

	}
}
