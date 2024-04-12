// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Outputs
{
	/*
		Gets the list of available outputs.)
	*/
	public struct GetOutputListRequestData
	{
	}
	public struct GetOutputListResponseData
	{
		[JsonProperty("outputs")]
		public Output[] Outputs;


	}
}
