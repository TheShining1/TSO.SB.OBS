// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Presses a button in the properties of an input.

Some known `propertyName` values are:

- `refreshnocache` - Browser source reload button

Note: Use this in cases where there is a button in the properties of an input that cannot be accessed in any other way. For example, browser sources, where there is a refresh button.)
	*/
	public struct PressInputPropertiesButtonRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("propertyName")]
		public string PropertyName;
	}
	public struct PressInputPropertiesButtonResponseData
	{

	}
}
