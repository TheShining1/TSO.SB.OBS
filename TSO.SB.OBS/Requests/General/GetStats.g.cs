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
		public int CpuUsage;

		[JsonProperty("memoryUsage")]
		public int MemoryUsage;

		[JsonProperty("availableDiskSpace")]
		public int AvailableDiskSpace;

		[JsonProperty("activeFps")]
		public int ActiveFps;

		[JsonProperty("averageFrameRenderTime")]
		public int AverageFrameRenderTime;

		[JsonProperty("renderSkippedFrames")]
		public int RenderSkippedFrames;

		[JsonProperty("renderTotalFrames")]
		public int RenderTotalFrames;

		[JsonProperty("outputSkippedFrames")]
		public int OutputSkippedFrames;

		[JsonProperty("outputTotalFrames")]
		public int OutputTotalFrames;

		[JsonProperty("webSocketSessionIncomingMessages")]
		public int WebSocketSessionIncomingMessages;

		[JsonProperty("webSocketSessionOutgoingMessages")]
		public int WebSocketSessionOutgoingMessages;


	}
}
