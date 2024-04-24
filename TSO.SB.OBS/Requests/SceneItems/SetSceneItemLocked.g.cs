// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Sets the lock state of a scene item.

Scenes and Group)
	*/
	public struct SetSceneItemLockedRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public double SceneItemId;
		[JsonProperty("sceneItemLocked")]
		public bool SceneItemLocked;
	}
	public struct SetSceneItemLockedResponseData
	{

	}
}
