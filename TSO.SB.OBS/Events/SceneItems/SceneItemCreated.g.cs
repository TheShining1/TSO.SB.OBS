// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		A scene item has been created.)
	*/
	public struct SceneItemCreatedEventData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("sourceUuid")]
		public string SourceUuid;

		[JsonProperty("sceneItemId")]
		public double SceneItemId;

		[JsonProperty("sceneItemIndex")]
		public double SceneItemIndex;

	}
}
