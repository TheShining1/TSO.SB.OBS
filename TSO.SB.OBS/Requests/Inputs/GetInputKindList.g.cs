// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets an array of all available input kinds in OBS.)
	*/
	public struct GetInputKindListRequestData
	{
		[JsonProperty("unversioned", NullValueHandling = NullValueHandling.Ignore)]
		public bool Unversioned;
	}
	public struct GetInputKindListResponseData
	{
		[JsonProperty("inputKinds")]
		public string[] InputKinds;


	}
}
