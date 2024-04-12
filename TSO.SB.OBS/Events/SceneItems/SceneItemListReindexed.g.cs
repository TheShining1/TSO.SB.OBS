// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		A scene's item list has been reindexed.)
	*/
	public struct SceneItemListReindexedEventData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("sceneItems")]
		public SceneItem[] SceneItems;

	}
}
