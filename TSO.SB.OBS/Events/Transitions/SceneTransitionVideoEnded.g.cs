// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		A scene transition's video has completed fully.

Useful for stinger transitions to tell when the video *actually* ends.
`SceneTransitionEnded` only signifies the cut point, not the completion of transition playback.

Note: Appears to be called by every transition, regardless of relevance.)
	*/
	public struct SceneTransitionVideoEndedEventData
	{
		[JsonProperty("transitionName")]
		public string TransitionName;

		[JsonProperty("transitionUuid")]
		public string TransitionUuid;

	}
}
