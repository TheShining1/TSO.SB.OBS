// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		Sets the settings of an output.)
	*/
	public struct SetOutputSettingsRequestData
	{
		[JsonProperty("outputName")]
		public string OutputName;
		[JsonProperty("outputSettings")]
		public Dictionary<string,object> OutputSettings;
	}
	public struct SetOutputSettingsResponseData
	{

	}
}
