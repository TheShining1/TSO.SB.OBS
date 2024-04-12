// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Sets the current stream service settings (stream destination).

Note: Simple RTMP settings can be set with type `rtmp_custom` and the settings fields `server` and `key`.)
	*/
	public struct SetStreamServiceSettingsRequestData
	{
		[JsonProperty("streamServiceType")]
		public string StreamServiceType;
		[JsonProperty("streamServiceSettings")]
		public StreamServiceSettings StreamServiceSettings;
	}
	public struct SetStreamServiceSettingsResponseData
	{

	}
}
