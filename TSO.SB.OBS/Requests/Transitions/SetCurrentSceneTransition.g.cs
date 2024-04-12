// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Sets the current scene transition.

Small note: While the namespace of scene transitions is generally unique, that uniqueness is not a guarantee as it is with other resources like inputs.)
	*/
	public struct SetCurrentSceneTransitionRequestData
	{
		[JsonProperty("transitionName")]
		public string TransitionName;
	}
	public struct SetCurrentSceneTransitionResponseData
	{

	}
}
