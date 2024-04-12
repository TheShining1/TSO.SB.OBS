// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Gets an array of all available transition kinds.

Similar to `GetInputKindList`)
	*/
	public struct GetTransitionKindListRequestData
	{
	}
	public struct GetTransitionKindListResponseData
	{
		[JsonProperty("transitionKinds")]
		public string[] TransitionKinds;


	}
}
