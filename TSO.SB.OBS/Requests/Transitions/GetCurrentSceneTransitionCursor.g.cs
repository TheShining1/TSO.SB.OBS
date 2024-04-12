// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Gets the cursor position of the current scene transition.

Note: `transitionCursor` will return 1.0 when the transition is inactive.)
	*/
	public struct GetCurrentSceneTransitionCursorRequestData
	{
	}
	public struct GetCurrentSceneTransitionCursorResponseData
	{
		[JsonProperty("transitionCursor")]
		public int TransitionCursor;


	}
}
