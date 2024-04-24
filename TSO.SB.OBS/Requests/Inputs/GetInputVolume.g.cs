// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the current volume setting of an input.)
	*/
	public struct GetInputVolumeRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
	}
	public struct GetInputVolumeResponseData
	{
		[JsonProperty("inputVolumeMul")]
		public double InputVolumeMul;

		[JsonProperty("inputVolumeDb")]
		public double InputVolumeDb;


	}
}
