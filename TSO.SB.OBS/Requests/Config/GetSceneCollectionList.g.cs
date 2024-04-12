// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Gets an array of all scene collections)
	*/
	public struct GetSceneCollectionListRequestData
	{
	}
	public struct GetSceneCollectionListResponseData
	{
		[JsonProperty("currentSceneCollectionName")]
		public string CurrentSceneCollectionName;

		[JsonProperty("sceneCollections")]
		public string[] SceneCollections;


	}
}
