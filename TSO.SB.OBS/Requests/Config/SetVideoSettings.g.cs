// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Sets the current video settings.

Note: Fields must be specified in pairs. For example, you cannot set only `baseWidth` without needing to specify `baseHeight`.)
	*/
	public struct SetVideoSettingsRequestData
	{
		[JsonProperty("fpsNumerator", NullValueHandling = NullValueHandling.Ignore)]
		public int FpsNumerator;
		[JsonProperty("fpsDenominator", NullValueHandling = NullValueHandling.Ignore)]
		public int FpsDenominator;
		[JsonProperty("baseWidth", NullValueHandling = NullValueHandling.Ignore)]
		public int BaseWidth;
		[JsonProperty("baseHeight", NullValueHandling = NullValueHandling.Ignore)]
		public int BaseHeight;
		[JsonProperty("outputWidth", NullValueHandling = NullValueHandling.Ignore)]
		public int OutputWidth;
		[JsonProperty("outputHeight", NullValueHandling = NullValueHandling.Ignore)]
		public int OutputHeight;
	}
	public struct SetVideoSettingsResponseData
	{

	}
}
