// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		The monitor type of an input has changed.

Available types are:

- `OBS_MONITORING_TYPE_NONE`
- `OBS_MONITORING_TYPE_MONITOR_ONLY`
- `OBS_MONITORING_TYPE_MONITOR_AND_OUTPUT`)
	*/
	public struct InputAudioMonitorTypeChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("monitorType")]
		public string MonitorType;

	}
}
