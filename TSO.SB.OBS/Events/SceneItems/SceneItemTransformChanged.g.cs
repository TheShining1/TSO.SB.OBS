// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		The transform/crop of a scene item has changed.)
	*/
	public struct SceneItemTransformChangedEventData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("sceneItemId")]
		public int SceneItemId;

		[JsonProperty("sceneItemTransform")]
		public SceneItemTransform SceneItemTransform;

	}
}
