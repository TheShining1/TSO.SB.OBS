// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Gets information about the current scene transition.)
	*/
	public struct GetCurrentSceneTransitionRequestData
	{
	}
	public struct GetCurrentSceneTransitionResponseData
	{
		[JsonProperty("transitionName")]
		public string TransitionName;

		[JsonProperty("transitionUuid")]
		public string TransitionUuid;

		[JsonProperty("transitionKind")]
		public string TransitionKind;

		[JsonProperty("transitionFixed")]
		public bool TransitionFixed;

		[JsonProperty("transitionDuration")]
		public int TransitionDuration;

		[JsonProperty("transitionConfigurable")]
		public bool TransitionConfigurable;

		[JsonProperty("transitionSettings")]
		public Dictionary<string,object> TransitionSettings;


	}
}
