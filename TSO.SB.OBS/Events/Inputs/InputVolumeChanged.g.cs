// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		An input's volume level has changed.)
	*/
	public struct InputVolumeChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("inputVolumeMul")]
		public double InputVolumeMul;

		[JsonProperty("inputVolumeDb")]
		public double InputVolumeDb;

	}
}
