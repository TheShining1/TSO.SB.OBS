// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Ui
{
	/*
		Opens a projector for a source.

Note: This request serves to provide feature parity with 4.x. It is very likely to be changed/deprecated in a future release.)
	*/
	public struct OpenSourceProjectorRequestData
	{
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("monitorIndex", NullValueHandling = NullValueHandling.Ignore)]
		public double? MonitorIndex;
		[JsonProperty("projectorGeometry", NullValueHandling = NullValueHandling.Ignore)]
		public string ProjectorGeometry;
	}
	public struct OpenSourceProjectorResponseData
	{

	}
}
