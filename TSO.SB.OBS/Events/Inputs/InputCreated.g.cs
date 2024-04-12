// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		An input has been created.)
	*/
	public struct InputCreatedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("inputKind")]
		public string InputKind;

		[JsonProperty("unversionedInputKind")]
		public string UnversionedInputKind;

		[JsonProperty("inputSettings")]
		public Dictionary<string,object> InputSettings;

		[JsonProperty("defaultInputSettings")]
		public Dictionary<string,object> DefaultInputSettings;

	}
}
