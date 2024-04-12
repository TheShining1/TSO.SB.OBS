// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Gets the current preview scene.

Only available when studio mode is enabled.

Note: This request is slated to have the `currentPreview`-prefixed fields removed from in an upcoming RPC version.)
	*/
	public struct GetCurrentPreviewSceneRequestData
	{
	}
	public struct GetCurrentPreviewSceneResponseData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("currentPreviewSceneName")]
		public string CurrentPreviewSceneName;

		[JsonProperty("currentPreviewSceneUuid")]
		public string CurrentPreviewSceneUuid;


	}
}
