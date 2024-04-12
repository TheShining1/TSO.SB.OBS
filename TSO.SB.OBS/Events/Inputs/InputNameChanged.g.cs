// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		The name of an input has changed.)
	*/
	public struct InputNameChangedEventData
	{
		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("oldInputName")]
		public string OldInputName;

		[JsonProperty("inputName")]
		public string InputName;

	}
}
