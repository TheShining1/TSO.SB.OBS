// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Gets an array of all of a source's filters.)
	*/
	public struct GetSourceFilterListRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
	}
	public struct GetSourceFilterListResponseData
	{
		[JsonProperty("filters")]
		public Filter[] Filters;


	}
}
