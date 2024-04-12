// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Sets the volume setting of an input.)
	*/
	public struct SetInputVolumeRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("inputVolumeMul", NullValueHandling = NullValueHandling.Ignore)]
		public int InputVolumeMul;
		[JsonProperty("inputVolumeDb", NullValueHandling = NullValueHandling.Ignore)]
		public int InputVolumeDb;
	}
	public struct SetInputVolumeResponseData
	{

	}
}
