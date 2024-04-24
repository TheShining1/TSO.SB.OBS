// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Gets the scene transition overridden for a scene.

Note: A transition UUID response field is not currently able to be implemented as of 2024-1-18.)
	*/
	public struct GetSceneSceneTransitionOverrideRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
	}
	public struct GetSceneSceneTransitionOverrideResponseData
	{
		[JsonProperty("transitionName")]
		public string TransitionName;

		[JsonProperty("transitionDuration")]
		public double TransitionDuration;


	}
}
