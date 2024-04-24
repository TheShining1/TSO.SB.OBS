// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Searches a scene for a source, and returns its id.

Scenes and Groups)
	*/
	public struct GetSceneItemIdRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sourceName")]
		public string SourceName;
		[JsonProperty("searchOffset", NullValueHandling = NullValueHandling.Ignore)]
		public double? SearchOffset;
	}
	public struct GetSceneItemIdResponseData
	{
		[JsonProperty("sceneItemId")]
		public double SceneItemId;


	}
}
