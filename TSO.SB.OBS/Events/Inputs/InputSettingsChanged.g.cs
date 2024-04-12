// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		An input's settings have changed (been updated).

Note: On some inputs, changing values in the properties dialog will cause an immediate update. Pressing the "Cancel" button will revert the settings, resulting in another event being fired.)
	*/
	public struct InputSettingsChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("inputSettings")]
		public Dictionary<string,object> InputSettings;

	}
}
