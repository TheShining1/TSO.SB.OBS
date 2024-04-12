// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Gets the current program scene.

Note: This request is slated to have the `currentProgram`-prefixed fields removed from in an upcoming RPC version.)
	*/
	public struct GetCurrentProgramSceneRequestData
	{
	}
	public struct GetCurrentProgramSceneResponseData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("currentProgramSceneName")]
		public string CurrentProgramSceneName;

		[JsonProperty("currentProgramSceneUuid")]
		public string CurrentProgramSceneUuid;


	}
}
