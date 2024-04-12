// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Sets the index position of a scene item in a scene.

Scenes and Groups)
	*/
	public struct SetSceneItemIndexRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public int SceneItemId;
		[JsonProperty("sceneItemIndex")]
		public int SceneItemIndex;
	}
	public struct SetSceneItemIndexResponseData
	{

	}
}
