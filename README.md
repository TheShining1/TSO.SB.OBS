# TSO.SB.OBS
Streamer.Bot helper library with OBS structures.

This repository contains a dynamic-link library (DLL) which you can use inside C# code sub-actions in Streamer.Bot's [`ObsSendRaw`](https://docs.streamer.bot/api/csharp/obs/raw#ObsSendRaw) method. It contains the set of structures for requset, response and event data used in OBS Websocket 5 ([OBS WebSocket protocol documentation](https://github.com/obsproject/obs-websocket/blob/master/docs/generated/protocol.md))

## Installation

- Place DLL in `Streamer.Bot/dlls/` folder (or any other)
- Add it to references in your C# sub-action (or in SB->Settings->C# Compiler->Common References)

## Usage

All names are in CamelCase style. 

Namespace's structure follows OBS WebSocket protocol structure, all types and enums are placed in root namespace `TSO.SB.OBS`.

Naming of structures is following: `RequestType` + `EventData` for events, `RequestType` + `RequestData` or `ResponseData`, depending on is it request or response.

More documentation will be added later ^_^

## Example

```
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TSO.SB.OBS;
using TSO.SB.OBS.SceneItems;

public class CPHInline
{
	public bool Execute()
	{
		var connectionName = "Main5"; // name of OBS connection from Stream Apps tab
		var connection = CPH.ObsGetConnectionByName(connectionName);
		
		var requestType = "GetSceneItemTransform";
		var requestData = new GetSceneItemTransformRequestData{
			SceneName = "Display",
			SceneItemId = 53
		};
		
		var data = JsonConvert.SerializeObject(requestData);
		
		var response = CPH.ObsSendRaw(requestType, data, connection);
				
		var responseData = JsonConvert.DeserializeObject<GetSceneItemTransformResponseData>(response);

		CPH.LogInfo($"GetSceneItemTransformResponseData.SceneItemTransform.: {responseData.SceneItemTransform.Alignment}");
		CPH.LogInfo($"GetSceneItemTransformResponseData.Rotation.: {responseData.SceneItemTransform.Rotation}");
		
		return true;
	}
}

```