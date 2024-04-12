// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Ui
{
	/*
		A screenshot has been saved.

Note: Triggered for the screenshot feature available in `Settings -> Hotkeys -> Screenshot Output` ONLY.
Applications using `Get/SaveSourceScreenshot` should implement a `CustomEvent` if this kind of inter-client
communication is desired.)
	*/
	public struct ScreenshotSavedEventData
	{
		[JsonProperty("savedScreenshotPath")]
		public string SavedScreenshotPath;

	}
}
