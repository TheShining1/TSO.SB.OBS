// This file has been automatically generated. Don't edit it.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TSO.SB.OBS.Inputs
{
	/*
		Gets the items of a list property from an input's properties.

Note: Use this in cases where an input provides a dynamic, selectable list of items. For example, display capture, where it provides a list of available displays.)
	*/
	public struct GetInputPropertiesListPropertyItemsRequestData
	{
		[JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
		public string InputName;
		[JsonProperty("inputUuid", NullValueHandling = NullValueHandling.Ignore)]
		public string InputUuid;
		[JsonProperty("propertyName")]
		public string PropertyName;
	}
	public struct GetInputPropertiesListPropertyItemsResponseData
	{
		[JsonProperty("propertyItems")]
		public PropertyItem[] PropertyItems;


	}
}
