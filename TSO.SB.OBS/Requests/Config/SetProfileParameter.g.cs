// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Sets the value of a parameter in the current profile's configuration.)
	*/
	public struct SetProfileParameterRequestData
	{
		[JsonProperty("parameterCategory")]
		public string ParameterCategory;
		[JsonProperty("parameterName")]
		public string ParameterName;
		[JsonProperty("parameterValue")]
		public string ParameterValue;
	}
	public struct SetProfileParameterResponseData
	{

	}
}
