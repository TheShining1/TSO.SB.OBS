// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets an array of all inputs in OBS.)
	*/
	public struct GetInputListRequestData
	{
		[JsonProperty("inputKind", NullValueHandling = NullValueHandling.Ignore)]
		public string InputKind;
	}
	public struct GetInputListResponseData
	{
		[JsonProperty("inputs")]
		public Input[] Inputs;


	}
}
