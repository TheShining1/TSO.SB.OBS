// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.MediaInputs
{
	/*
		An action has been performed on an input.)
	*/
	public struct MediaInputActionTriggeredEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("mediaAction")]
		public string MediaAction;

	}
}
