// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		A scene transition has completed fully.

Note: Does not appear to trigger when the transition is interrupted by the user.)
	*/
	public struct SceneTransitionEndedEventData
	{
		[JsonProperty("transitionName")]
		public string TransitionName;

		[JsonProperty("transitionUuid")]
		public string TransitionUuid;

	}
}
