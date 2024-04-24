// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Duplicates a scene item, copying all transform and crop info.

Scenes only)
	*/
	public struct DuplicateSceneItemRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public double SceneItemId;
		[JsonProperty("destinationSceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string DestinationSceneName;
		[JsonProperty("destinationSceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string DestinationSceneUuid;
	}
	public struct DuplicateSceneItemResponseData
	{
		[JsonProperty("sceneItemId")]
		public double SceneItemId;


	}
}
