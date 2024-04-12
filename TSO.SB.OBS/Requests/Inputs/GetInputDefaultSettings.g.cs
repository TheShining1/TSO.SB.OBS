// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the default settings for an input kind.)
	*/
	public struct GetInputDefaultSettingsRequestData
	{
		[JsonProperty("inputKind")]
		public string InputKind;
	}
	public struct GetInputDefaultSettingsResponseData
	{
		[JsonProperty("defaultInputSettings")]
		public Dictionary<string,object> DefaultInputSettings;


	}
}
