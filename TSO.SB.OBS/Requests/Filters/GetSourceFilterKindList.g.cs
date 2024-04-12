// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Filters
{
	/*
		Gets an array of all available source filter kinds.

Similar to `GetInputKindList`)
	*/
	public struct GetSourceFilterKindListRequestData
	{
	}
	public struct GetSourceFilterKindListResponseData
	{
		[JsonProperty("sourceFilterKinds")]
		public string[] SourceFilterKinds;


	}
}
