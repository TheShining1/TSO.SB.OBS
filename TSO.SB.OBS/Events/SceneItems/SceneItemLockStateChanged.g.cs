// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		A scene item's lock state has changed.)
	*/
	public struct SceneItemLockStateChangedEventData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("sceneItemId")]
		public double SceneItemId;

		[JsonProperty("sceneItemLocked")]
		public bool SceneItemLocked;

	}
}
