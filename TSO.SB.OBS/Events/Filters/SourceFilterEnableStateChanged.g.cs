// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		A source filter's enable state has changed.)
	*/
	public struct SourceFilterEnableStateChangedEventData
	{
		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("filterName")]
		public string FilterName;

		[JsonProperty("filterEnabled")]
		public bool FilterEnabled;

	}
}
