// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.MediaInputs
{
	/*
		Offsets the current cursor position of a media input by the specified value.

This request does not perform bounds checking of the cursor position.)
	*/
	public struct OffsetMediaInputCursorRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("mediaCursorOffset")]
		public int MediaCursorOffset;
	}
	public struct OffsetMediaInputCursorResponseData
	{

	}
}
