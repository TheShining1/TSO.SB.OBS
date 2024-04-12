// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		A source's filter list has been reindexed.)
	*/
	public struct SourceFilterListReindexedEventData
	{
		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("filters")]
		public Filter[] Filters;

	}
}
