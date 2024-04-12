// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		Toggles the status of an output.)
	*/
	public struct ToggleOutputRequestData
	{
		[JsonProperty("outputName")]
		public string OutputName;
	}
	public struct ToggleOutputResponseData
	{
		[JsonProperty("outputActive")]
		public bool OutputActive;


	}
}
