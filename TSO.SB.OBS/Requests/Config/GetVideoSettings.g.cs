// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Gets the current video settings.

Note: To get the true FPS value, divide the FPS numerator by the FPS denominator. Example: `60000/1001`)
	*/
	public struct GetVideoSettingsRequestData
	{
	}
	public struct GetVideoSettingsResponseData
	{
		[JsonProperty("fpsNumerator")]
		public int FpsNumerator;

		[JsonProperty("fpsDenominator")]
		public int FpsDenominator;

		[JsonProperty("baseWidth")]
		public int BaseWidth;

		[JsonProperty("baseHeight")]
		public int BaseHeight;

		[JsonProperty("outputWidth")]
		public int OutputWidth;

		[JsonProperty("outputHeight")]
		public int OutputHeight;


	}
}
