// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Gets an array of all groups in OBS.

Groups in OBS are actually scenes, but renamed and modified. In obs-websocket, we treat them as scenes where we can.)
	*/
	public struct GetGroupListRequestData
	{
	}
	public struct GetGroupListResponseData
	{
		[JsonProperty("groups")]
		public string[] Groups;


	}
}
