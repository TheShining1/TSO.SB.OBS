// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Sources
{
	/*
		Saves a screenshot of a source to the filesystem.

The `imageWidth` and `imageHeight` parameters are treated as "scale to inner", meaning the smallest ratio will be used and the aspect ratio of the original resolution is kept.
If `imageWidth` and `imageHeight` are not specified, the compressed image will use the full resolution of the source.

**Compatible with inputs and scenes.**)
	*/
	public struct SaveSourceScreenshotRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("imageFormat")]
		public string ImageFormat;
		[JsonProperty("imageFilePath")]
		public string ImageFilePath;
		[JsonProperty("imageWidth", NullValueHandling = NullValueHandling.Ignore)]
		public int ImageWidth;
		[JsonProperty("imageHeight", NullValueHandling = NullValueHandling.Ignore)]
		public int ImageHeight;
		[JsonProperty("imageCompressionQuality", NullValueHandling = NullValueHandling.Ignore)]
		public int ImageCompressionQuality;
	}
	public struct SaveSourceScreenshotResponseData
	{

	}
}
