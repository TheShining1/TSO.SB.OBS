// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Ui
{
	/*
		Opens a projector for a specific output video mix.

Mix types:

- `OBS_WEBSOCKET_VIDEO_MIX_TYPE_PREVIEW`
- `OBS_WEBSOCKET_VIDEO_MIX_TYPE_PROGRAM`
- `OBS_WEBSOCKET_VIDEO_MIX_TYPE_MULTIVIEW`

Note: This request serves to provide feature parity with 4.x. It is very likely to be changed/deprecated in a future release.)
	*/
	public struct OpenVideoMixProjectorRequestData
	{
		[JsonProperty("videoMixType")]
		public string VideoMixType;
		[JsonProperty("monitorIndex", NullValueHandling = NullValueHandling.Ignore)]
		public double? MonitorIndex;
		[JsonProperty("projectorGeometry", NullValueHandling = NullValueHandling.Ignore)]
		public string ProjectorGeometry;
	}
	public struct OpenVideoMixProjectorResponseData
	{

	}
}
