// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		Basically GetSceneItemList, but for groups.

Using groups at all in OBS is discouraged, as they are very broken under the hood. Please use nested scenes instead.

Groups only)
	*/
	public struct GetGroupSceneItemListRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
	}
	public struct GetGroupSceneItemListResponseData
	{
		[JsonProperty("sceneItems")]
		public SceneItem[] SceneItems;


	}
}
