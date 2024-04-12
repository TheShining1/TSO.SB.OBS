// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Sets the enable state of a scene item.

Scenes and Groups)
	*/
	public struct SetSceneItemEnabledRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public int SceneItemId;
		[JsonProperty("sceneItemEnabled")]
		public bool SceneItemEnabled;
	}
	public struct SetSceneItemEnabledResponseData
	{

	}
}
