// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Gets a parameter from the current profile's configuration.)
	*/
	public struct GetProfileParameterRequestData
	{
		[JsonProperty("parameterCategory")]
		public string ParameterCategory;
		[JsonProperty("parameterName")]
		public string ParameterName;
	}
	public struct GetProfileParameterResponseData
	{
		[JsonProperty("parameterValue")]
		public string ParameterValue;

		[JsonProperty("defaultParameterValue")]
		public string DefaultParameterValue;


	}
}
