// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		The name of a source filter has changed.)
	*/
	public struct SourceFilterNameChangedEventData
	{
		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("oldFilterName")]
		public string OldFilterName;

		[JsonProperty("filterName")]
		public string FilterName;

	}
}
