// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		The current scene collection has changed.

Note: If polling has been paused during `CurrentSceneCollectionChanging`, this is the que to restart polling.)
	*/
	public struct CurrentSceneCollectionChangedEventData
	{
		[JsonProperty("sceneCollectionName")]
		public string SceneCollectionName;

	}
}
