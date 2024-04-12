// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Sets the enable state of a source filter.)
	*/
	public struct SetSourceFilterEnabledRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("filterName")]
		public string FilterName;
		[JsonProperty("filterEnabled")]
		public bool FilterEnabled;
	}
	public struct SetSourceFilterEnabledResponseData
	{

	}
}
