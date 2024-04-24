// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		A filter has been added to a source.)
	*/
	public struct SourceFilterCreatedEventData
	{
		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("filterName")]
		public string FilterName;

		[JsonProperty("filterKind")]
		public string FilterKind;

		[JsonProperty("filterIndex")]
		public double FilterIndex;

		[JsonProperty("filterSettings")]
		public Dictionary<string,object> FilterSettings;

		[JsonProperty("defaultFilterSettings")]
		public Dictionary<string,object> DefaultFilterSettings;

	}
}
