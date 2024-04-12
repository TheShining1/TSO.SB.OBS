// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Sets the audio monitor type of an input.)
	*/
	public struct SetInputAudioMonitorTypeRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("monitorType")]
		public string MonitorType;
	}
	public struct SetInputAudioMonitorTypeResponseData
	{

	}
}
