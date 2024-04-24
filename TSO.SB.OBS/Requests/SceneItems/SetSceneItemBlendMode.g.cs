// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Sets the blend mode of a scene item.

Scenes and Groups)
	*/
	public struct SetSceneItemBlendModeRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public double SceneItemId;
		[JsonProperty("sceneItemBlendMode")]
		public string SceneItemBlendMode;
	}
	public struct SetSceneItemBlendModeResponseData
	{

	}
}
