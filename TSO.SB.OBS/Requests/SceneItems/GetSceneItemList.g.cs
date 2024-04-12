// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Gets a list of all scene items in a scene.

Scenes only)
	*/
	public struct GetSceneItemListRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
	}
	public struct GetSceneItemListResponseData
	{
		[JsonProperty("sceneItems")]
		public SceneItem[] SceneItems;


	}
}
