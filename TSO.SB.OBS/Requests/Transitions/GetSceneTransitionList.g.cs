// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Transitions
{
	/*
		Gets an array of all scene transitions in OBS.)
	*/
	public struct GetSceneTransitionListRequestData
	{
	}
	public struct GetSceneTransitionListResponseData
	{
		[JsonProperty("currentSceneTransitionName")]
		public string CurrentSceneTransitionName;

		[JsonProperty("currentSceneTransitionUuid")]
		public string CurrentSceneTransitionUuid;

		[JsonProperty("currentSceneTransitionKind")]
		public string CurrentSceneTransitionKind;

		[JsonProperty("transitions")]
		public Transition[] Transitions;


	}
}
