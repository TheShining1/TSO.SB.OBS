// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Sets the transform and crop info of a scene item.)
	*/
	public struct SetSceneItemTransformRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public double SceneItemId;
		[JsonProperty("sceneItemTransform")]
		public SceneItemTransform SceneItemTransform;
	}
	public struct SetSceneItemTransformResponseData
	{

	}
}
