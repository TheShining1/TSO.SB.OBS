// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Gets statistics about OBS, obs-websocket, and the current session.)
	*/
	public struct GetStatsRequestData
	{
	}
	public struct GetStatsResponseData
	{
		[JsonProperty("cpuUsage")]
		public double CpuUsage;

		[JsonProperty("memoryUsage")]
		public double MemoryUsage;

		[JsonProperty("availableDiskSpace")]
		public double AvailableDiskSpace;

		[JsonProperty("activeFps")]
		public double ActiveFps;

		[JsonProperty("averageFrameRenderTime")]
		public double AverageFrameRenderTime;

		[JsonProperty("renderSkippedFrames")]
		public double RenderSkippedFrames;

		[JsonProperty("renderTotalFrames")]
		public double RenderTotalFrames;

		[JsonProperty("outputSkippedFrames")]
		public double OutputSkippedFrames;

		[JsonProperty("outputTotalFrames")]
		public double OutputTotalFrames;

		[JsonProperty("webSocketSessionIncomingMessages")]
		public double WebSocketSessionIncomingMessages;

		[JsonProperty("webSocketSessionOutgoingMessages")]
		public double WebSocketSessionOutgoingMessages;


	}
}
