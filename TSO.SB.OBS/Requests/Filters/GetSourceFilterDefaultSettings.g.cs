// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Gets the default settings for a filter kind.)
	*/
	public struct GetSourceFilterDefaultSettingsRequestData
	{
		[JsonProperty("filterKind")]
		public string FilterKind;
	}
	public struct GetSourceFilterDefaultSettingsResponseData
	{
		[JsonProperty("defaultFilterSettings")]
		public Dictionary<string,object> DefaultFilterSettings;


	}
}
