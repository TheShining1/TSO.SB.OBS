// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Sets the settings of a source filter.)
	*/
	public struct SetSourceFilterSettingsRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("filterName")]
		public string FilterName;
		[JsonProperty("filterSettings")]
		public Dictionary<string,object> FilterSettings;
		[JsonProperty("overlay", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Overlay;
	}
	public struct SetSourceFilterSettingsResponseData
	{

	}
}
