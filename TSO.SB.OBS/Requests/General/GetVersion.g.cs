// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Gets data about the current plugin and RPC version.)
	*/
	public struct GetVersionRequestData
	{
	}
	public struct GetVersionResponseData
	{
		[JsonProperty("obsVersion")]
		public string ObsVersion;

		[JsonProperty("obsWebSocketVersion")]
		public string ObsWebSocketVersion;

		[JsonProperty("rpcVersion")]
		public int RpcVersion;

		[JsonProperty("availableRequests")]
		public string[] AvailableRequests;

		[JsonProperty("supportedImageFormats")]
		public string[] SupportedImageFormats;

		[JsonProperty("platform")]
		public string Platform;

		[JsonProperty("platformDescription")]
		public string PlatformDescription;


	}
}
