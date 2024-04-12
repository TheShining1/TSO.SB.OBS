// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Gets the current stream service settings (stream destination).)
	*/
	public struct GetStreamServiceSettingsRequestData
	{
	}
	public struct GetStreamServiceSettingsResponseData
	{
		[JsonProperty("streamServiceType")]
		public string StreamServiceType;

		[JsonProperty("streamServiceSettings")]
		public StreamServiceSettings StreamServiceSettings;


	}
}
