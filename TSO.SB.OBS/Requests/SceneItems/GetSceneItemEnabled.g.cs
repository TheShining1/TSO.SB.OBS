// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Gets the enable state of a scene item.

Scenes and Groups)
	*/
	public struct GetSceneItemEnabledRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public int SceneItemId;
	}
	public struct GetSceneItemEnabledResponseData
	{
		[JsonProperty("sceneItemEnabled")]
		public bool SceneItemEnabled;


	}
}
