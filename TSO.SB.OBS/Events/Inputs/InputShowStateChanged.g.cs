// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		An input's show state has changed.

When an input is showing, it means it's being shown by the preview or a dialog.)
	*/
	public struct InputShowStateChangedEventData
	{
		[JsonProperty("inputName")]
		public string InputName;

		[JsonProperty("inputUuid")]
		public string InputUuid;

		[JsonProperty("videoShowing")]
		public bool VideoShowing;

	}
}
