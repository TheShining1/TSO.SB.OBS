// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Creates a new scene item using a source.

Scenes only)
	*/
	public struct CreateSceneItemRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName;
		[JsonProperty("sourceUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceUuid;
		[JsonProperty("sceneItemEnabled", NullValueHandling = NullValueHandling.Ignore)]
		public bool? SceneItemEnabled;
	}
	public struct CreateSceneItemResponseData
	{
		[JsonProperty("sceneItemId")]
		public double SceneItemId;


	}
}
