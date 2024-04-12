// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Config
{
	/*
		Gets an array of all profiles)
	*/
	public struct GetProfileListRequestData
	{
	}
	public struct GetProfileListResponseData
	{
		[JsonProperty("currentProfileName")]
		public string CurrentProfileName;

		[JsonProperty("profiles")]
		public string[] Profiles;


	}
}
