// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Sources
{
	/*
		Gets a Base64-encoded screenshot of a source.

The `imageWidth` and `imageHeight` parameters are treated as "scale to inner", meaning the smallest ratio will be used and the aspect ratio of the original resolution is kept.
If `imageWidth` and `imageHeight` are not specified, the compressed image will use the full resolution of the source.

**Compatible with inputs and scenes.**)
	*/
	public struct GetSourceScreenshotRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("imageFormat")]
		public string ImageFormat;
		[JsonProperty("imageWidth", NullValueHandling = NullValueHandling.Ignore)]
		public int ImageWidth;
		[JsonProperty("imageHeight", NullValueHandling = NullValueHandling.Ignore)]
		public int ImageHeight;
		[JsonProperty("imageCompressionQuality", NullValueHandling = NullValueHandling.Ignore)]
		public int ImageCompressionQuality;
	}
	public struct GetSourceScreenshotResponseData
	{
		[JsonProperty("imageData")]
		public string ImageData;


	}
}
