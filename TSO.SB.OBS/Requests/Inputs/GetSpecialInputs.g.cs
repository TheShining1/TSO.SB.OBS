// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the names of all special inputs.)
	*/
	public struct GetSpecialInputsRequestData
	{
	}
	public struct GetSpecialInputsResponseData
	{
		[JsonProperty("desktop1")]
		public string Desktop1;

		[JsonProperty("desktop2")]
		public string Desktop2;

		[JsonProperty("mic1")]
		public string Mic1;

		[JsonProperty("mic2")]
		public string Mic2;

		[JsonProperty("mic3")]
		public string Mic3;

		[JsonProperty("mic4")]
		public string Mic4;


	}
}
