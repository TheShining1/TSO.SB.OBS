// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.MediaInputs
{
	/*
		Gets the status of a media input.

Media States:

- `OBS_MEDIA_STATE_NONE`
- `OBS_MEDIA_STATE_PLAYING`
- `OBS_MEDIA_STATE_OPENING`
- `OBS_MEDIA_STATE_BUFFERING`
- `OBS_MEDIA_STATE_PAUSED`
- `OBS_MEDIA_STATE_STOPPED`
- `OBS_MEDIA_STATE_ENDED`
- `OBS_MEDIA_STATE_ERROR`)
	*/
	public struct GetMediaInputStatusRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
	}
	public struct GetMediaInputStatusResponseData
	{
		[JsonProperty("mediaState")]
		public string MediaState;

		[JsonProperty("mediaDuration")]
		public double MediaDuration;

		[JsonProperty("mediaCursor")]
		public double MediaCursor;


	}
}
