// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Sets the name of a source filter (rename).)
	*/
	public struct SetSourceFilterNameRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("filterName")]
		public string FilterName;
		[JsonProperty("newFilterName")]
		public string NewFilterName;
	}
	public struct SetSourceFilterNameResponseData
	{

	}
}
