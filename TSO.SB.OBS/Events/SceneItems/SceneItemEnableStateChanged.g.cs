// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		A scene item's enable state has changed.)
	*/
	public struct SceneItemEnableStateChangedEventData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("sceneItemId")]
		public double SceneItemId;

		[JsonProperty("sceneItemEnabled")]
		public bool SceneItemEnabled;

	}
}
