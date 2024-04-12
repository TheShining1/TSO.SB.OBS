// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Ui
{
	/*
		Gets a list of connected monitors and information about them.)
	*/
	public struct GetMonitorListRequestData
	{
	}
	public struct GetMonitorListResponseData
	{
		[JsonProperty("monitors")]
		public Monitor[] Monitors;


	}
}
