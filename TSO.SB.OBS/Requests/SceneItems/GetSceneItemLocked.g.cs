// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Gets the lock state of a scene item.

Scenes and Groups)
	*/
	public struct GetSceneItemLockedRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public double SceneItemId;
	}
	public struct GetSceneItemLockedResponseData
	{
		[JsonProperty("sceneItemLocked")]
		public bool SceneItemLocked;


	}
}
