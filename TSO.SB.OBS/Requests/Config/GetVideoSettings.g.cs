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
		public double FpsNumerator;

		[JsonProperty("fpsDenominator")]
		public double FpsDenominator;

		[JsonProperty("baseWidth")]
		public double BaseWidth;

		[JsonProperty("baseHeight")]
		public double BaseHeight;

		[JsonProperty("outputWidth")]
		public double OutputWidth;

		[JsonProperty("outputHeight")]
		public double OutputHeight;


	}
}
