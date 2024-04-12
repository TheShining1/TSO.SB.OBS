// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		Gets an array of all scenes in OBS.)
	*/
	public struct GetSceneListRequestData
	{
	}
	public struct GetSceneListResponseData
	{
		[JsonProperty("currentProgramSceneName")]
		public string CurrentProgramSceneName;

		[JsonProperty("currentProgramSceneUuid")]
		public string CurrentProgramSceneUuid;

		[JsonProperty("currentPreviewSceneName")]
		public string CurrentPreviewSceneName;

		[JsonProperty("currentPreviewSceneUuid")]
		public string CurrentPreviewSceneUuid;

		[JsonProperty("scenes")]
		public Scene[] Scenes;


	}
}
