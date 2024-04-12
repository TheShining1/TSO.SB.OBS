// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		An source filter's settings have changed (been updated).)
	*/
	public struct SourceFilterSettingsChangedEventData
	{
		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("filterName")]
		public string FilterName;

		[JsonProperty("filterSettings")]
		public Dictionary<string,object> FilterSettings;

	}
}
