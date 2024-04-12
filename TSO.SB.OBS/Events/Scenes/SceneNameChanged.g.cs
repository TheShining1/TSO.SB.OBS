// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		The name of a scene has changed.)
	*/
	public struct SceneNameChangedEventData
	{
		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("oldSceneName")]
		public string OldSceneName;

		[JsonProperty("sceneName")]
		public string SceneName;

	}
}
