// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Gets the source associated with a scene item.)
	*/
	public struct GetSceneItemSourceRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("sceneItemId")]
		public int SceneItemId;
	}
	public struct GetSceneItemSourceResponseData
	{
		[JsonProperty("sourceName")]
		public string SourceName;

		[JsonProperty("sourceUuid")]
		public string SourceUuid;


	}
}
