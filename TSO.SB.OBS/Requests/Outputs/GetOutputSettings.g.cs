// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		Gets the settings of an output.)
	*/
	public struct GetOutputSettingsRequestData
	{
		[JsonProperty("outputName")]
		public string OutputName;
	}
	public struct GetOutputSettingsResponseData
	{
		[JsonProperty("outputSettings")]
		public Dictionary<string,object> OutputSettings;


	}
}
