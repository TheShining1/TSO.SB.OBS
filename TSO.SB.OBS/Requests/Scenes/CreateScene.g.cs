// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Creates a new scene in OBS.)
	*/
	public struct CreateSceneRequestData
	{
		[JsonProperty("sceneName")]
		public string SceneName;
	}
	public struct CreateSceneResponseData
	{
		[JsonProperty("sceneUuid")]
		public string SceneUuid;


	}
}
