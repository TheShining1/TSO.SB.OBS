// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.SceneItems
{
	/*
		A scene item has been selected in the Ui.)
	*/
	public struct SceneItemSelectedEventData
	{
		[JsonProperty("sceneName")]
		public string SceneName;

		[JsonProperty("sceneUuid")]
		public string SceneUuid;

		[JsonProperty("sceneItemId")]
		public double SceneItemId;

	}
}
