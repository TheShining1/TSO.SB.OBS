// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		The current scene collection has begun changing.

Note: We recommend using this event to trigger a pause of all polling requests, as performing any requests during a
scene collection change is considered undefined behavior and can cause crashes!)
	*/
	public struct CurrentSceneCollectionChangingEventData
	{
		[JsonProperty("sceneCollectionName")]
		public string SceneCollectionName;

	}
}
