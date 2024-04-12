// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Sets the settings of the current scene transition.)
	*/
	public struct SetCurrentSceneTransitionSettingsRequestData
	{
		[JsonProperty("transitionSettings")]
		public Dictionary<string,object> TransitionSettings;
		[JsonProperty("overlay", NullValueHandling = NullValueHandling.Ignore)]
		public bool Overlay;
	}
	public struct SetCurrentSceneTransitionSettingsResponseData
	{

	}
}
