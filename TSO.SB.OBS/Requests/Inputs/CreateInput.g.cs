// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Creates a new input, adding it as a scene item to the specified scene.)
	*/
	public struct CreateInputRequestData
	{
		[JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneName;
		[JsonProperty("sceneUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string SceneUuid;
		[JsonProperty("inputName")]
		public string InputName;
		[JsonProperty("inputKind")]
		public string InputKind;
		[JsonProperty("inputSettings", NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string,object> InputSettings;
		[JsonProperty("sceneItemEnabled", NullValueHandling = NullValueHandling.Ignore)]
		public bool SceneItemEnabled;
	}
	public struct CreateInputResponseData
	{
		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("sceneItemId")]
		public int SceneItemId;


	}
}
