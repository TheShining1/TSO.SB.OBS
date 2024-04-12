// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Sets the scene transition overridden for a scene.)
	*/
	public struct SetSceneSceneTransitionOverrideRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("transitionName", NullValueHandling = NullValueHandling.Ignore)]
		public string TransitionName;
		[JsonProperty("transitionDuration", NullValueHandling = NullValueHandling.Ignore)]
		public int TransitionDuration;
	}
	public struct SetSceneSceneTransitionOverrideResponseData
	{

	}
}
