// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Triggers a hotkey using its name. See `GetHotkeyList`.

Note: Hotkey functionality in obs-websocket comes as-is, and we do not guarantee support if things are broken. In 9/10 usages of hotkey requests, there exists a better, more reliable method via other requests.)
	*/
	public struct TriggerHotkeyByNameRequestData
	{
		[JsonProperty("hotkeyName")]
		public string HotkeyName;
		[JsonProperty("contextName", NullValueHandling = NullValueHandling.Ignore)]
		public string ContextName;
	}
	public struct TriggerHotkeyByNameResponseData
	{

	}
}
