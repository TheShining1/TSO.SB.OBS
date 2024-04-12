// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Scenes
{
	/*
		The list of scenes has changed.

TODO: Make OBS fire this event when scenes are reordered.)
	*/
	public struct SceneListChangedEventData
	{
		[JsonProperty("scenes")]
		public Scene[] Scenes;

	}
}
