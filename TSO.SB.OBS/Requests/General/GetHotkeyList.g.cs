// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.General
{
	/*
		Gets an array of all hotkey names in OBS.

Note: Hotkey functionality in obs-websocket comes as-is, and we do not guarantee support if things are broken. In 9/10 usages of hotkey requests, there exists a better, more reliable method via other requests.)
	*/
	public struct GetHotkeyListRequestData
	{
	}
	public struct GetHotkeyListResponseData
	{
		[JsonProperty("hotkeys")]
		public string[] Hotkeys;


	}
}
