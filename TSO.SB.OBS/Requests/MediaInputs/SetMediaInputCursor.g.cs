// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.MediaInputs
{
	/*
		Sets the cursor position of a media input.

This request does not perform bounds checking of the cursor position.)
	*/
	public struct SetMediaInputCursorRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("mediaCursor")]
		public int MediaCursor;
	}
	public struct SetMediaInputCursorResponseData
	{

	}
}
