using System.Collections.Generic;

using Newtonsoft.Json;

namespace TSO.SB.OBS
{
  public struct Input
  {
    [JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
    public string InputName { get; set; }

    [JsonProperty("inputKind", NullValueHandling = NullValueHandling.Ignore)]
    public string InputKind { get; set; }

    [JsonProperty("unversionedInputKind", NullValueHandling = NullValueHandling.Ignore)]
    public string UnversionedInputKind { get; set; }
  }

  public struct Output
  {
    [JsonProperty("outputName", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("outputKind", NullValueHandling = NullValueHandling.Ignore)]
    public string Kind { get; set; }

    [JsonProperty("outputWidth", NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; }

    [JsonProperty("outputHeight", NullValueHandling = NullValueHandling.Ignore)]
    public int? Height { get; set; }

    [JsonProperty("outputActive", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; }

    [JsonProperty("outputFlags", NullValueHandling = NullValueHandling.Ignore)]
    public OutputFlags Flags { get; set; }
  }

  public struct OutputFlags
  {
    [JsonProperty("OBS_OUTPUT_AUDIO", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Audio { get; set; }

    [JsonProperty("OBS_OUTPUT_VIDEO", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Video { get; set; }

    [JsonProperty("OBS_OUTPUT_ENCODED", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Encoded { get; set; }

    [JsonProperty("OBS_OUTPUT_MULTI_TRACK", NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiTrack { get; set; }

    [JsonProperty("OBS_OUTPUT_SERVICE", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Service { get; set; }
  }

  public struct Scene
  {
    [JsonProperty("sceneIndex", NullValueHandling = NullValueHandling.Ignore)]
    public int? SceneIndex { get; set; }

    [JsonProperty("sceneName", NullValueHandling = NullValueHandling.Ignore)]
    public string SceneName { get; set; }
  }

  public struct PropertyItem
  {
    [JsonProperty("itemName", NullValueHandling = NullValueHandling.Ignore)]
    public string ItemName { get; set; }

    [JsonProperty("itemEnabled", NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemEnabled { get; set; }

    [JsonProperty("itemValue", NullValueHandling = NullValueHandling.Ignore)]
    public object ItemValue { get; set; }
  }

  public struct Filter
  {
    [JsonProperty("filterEnabled", NullValueHandling = NullValueHandling.Ignore)]
    public bool? FilterEnabled { get; set; }

    [JsonProperty("filterIndex", NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterIndex { get; set; }

    [JsonProperty("filterKind", NullValueHandling = NullValueHandling.Ignore)]
    public string FilterKind { get; set; }

    [JsonProperty("filterName", NullValueHandling = NullValueHandling.Ignore)]
    public string FilterName { get; set; }

    [JsonProperty("filterSettings", NullValueHandling = NullValueHandling.Ignore)]
    public Dictionary<string, object> FilterSettings { get; set; }
  }

  public struct Transition
  {
    [JsonProperty("transitionConfigurable", NullValueHandling = NullValueHandling.Ignore)]
    public bool? TransitionConfigurable { get; set; }

    [JsonProperty("transitionFixed", NullValueHandling = NullValueHandling.Ignore)]
    public bool? TransitionFixed { get; set; }

    [JsonProperty("transitionKind", NullValueHandling = NullValueHandling.Ignore)]
    public string TransitionKind { get; set; }

    [JsonProperty("transitionName", NullValueHandling = NullValueHandling.Ignore)]
    public string TransitionName { get; set; }
  }

  public struct SceneItemBasic
  {
    [JsonProperty("sceneItemId", NullValueHandling = NullValueHandling.Ignore)]
    public int? SceneItemID { get; set; }

    [JsonProperty("sceneItemIndex", NullValueHandling = NullValueHandling.Ignore)]
    public int? SceneItemIndex { get; set; }
  }

  public struct SceneItem
  {
    [JsonProperty("inputKind", NullValueHandling = NullValueHandling.Ignore)]
    public string InputKind { get; set; }

    [JsonProperty("isGroup", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGroup { get; set; }

    [JsonProperty("sceneItemBlendMode", NullValueHandling = NullValueHandling.Ignore)]
    public string SceneItemBlendMode { get; set; }

    [JsonProperty("sceneItemEnabled", NullValueHandling = NullValueHandling.Ignore)]
    public bool? SceneItemEnabled { get; set; }

    [JsonProperty("sceneItemId", NullValueHandling = NullValueHandling.Ignore)]
    public int? SceneItemID { get; set; }

    [JsonProperty("sceneItemIndex", NullValueHandling = NullValueHandling.Ignore)]
    public int? SceneItemIndex { get; set; }

    [JsonProperty("sceneItemLocked", NullValueHandling = NullValueHandling.Ignore)]
    public bool? SceneItemLocked { get; set; }

    [JsonProperty("sceneItemTransform", NullValueHandling = NullValueHandling.Ignore)]
    public SceneItemTransform SceneItemTransform { get; set; }

    [JsonProperty("sourceName", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceName { get; set; }

    [JsonProperty("sourceType", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceType { get; set; }
  }

  public class InputAudioTracks : Dictionary<string, bool?> { }

  public struct KeyModifiers
  {
    [JsonProperty("face", NullValueHandling = NullValueHandling.Ignore)]
    public string Shift { get; set; }

    [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
    public int? Control { get; set; }

    [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
    public int? Alt { get; set; }

    [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
    public string Command { get; set; }
  }

  public struct Monitor
  {
    [JsonProperty("monitorHeight", NullValueHandling = NullValueHandling.Ignore)]
    public int? MonitorHeight { get; set; }

    [JsonProperty("monitorIndex", NullValueHandling = NullValueHandling.Ignore)]
    public int? MonitorIndex { get; set; }

    [JsonProperty("monitorName", NullValueHandling = NullValueHandling.Ignore)]
    public string MonitorName { get; set; }

    [JsonProperty("monitorPositionX", NullValueHandling = NullValueHandling.Ignore)]
    public int? MonitorPositionX { get; set; }

    [JsonProperty("monitorPositionY", NullValueHandling = NullValueHandling.Ignore)]
    public int? MonitorPositionY { get; set; }

    [JsonProperty("monitorWidth", NullValueHandling = NullValueHandling.Ignore)]
    public int? MonitorWidth { get; set; }
  }

  public struct StreamServiceSettings
  {
    [JsonProperty("bwtest", NullValueHandling = NullValueHandling.Ignore)]
    public bool? Bwtest { get; set; }

    [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
    public string Key { get; set; }

    [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
    public string Password { get; set; }

    [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
    public string Server { get; set; }

    [JsonProperty("use_auth", NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseAuth { get; set; }

    [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
    public string Username { get; set; }

    [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
    public string Protocol { get; set; }

    [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
    public string Service { get; set; }
  }

  public struct SceneItemTransform
  {
    [JsonProperty("alignment", NullValueHandling = NullValueHandling.Ignore)]
    public double? Alignment { get; set; }

    [JsonProperty("boundsAlignment", NullValueHandling = NullValueHandling.Ignore)]
    public double? BoundsAlignment { get; set; }

    [JsonProperty("boundsHeight", NullValueHandling = NullValueHandling.Ignore)]
    public double? BoundsHeight { get; set; }

    [JsonProperty("boundsType", NullValueHandling = NullValueHandling.Ignore)]
    public string BoundsType { get; set; }

    [JsonProperty("boundsWidth", NullValueHandling = NullValueHandling.Ignore)]
    public double? BoundsWidth { get; set; }

    [JsonProperty("cropBottom", NullValueHandling = NullValueHandling.Ignore)]
    public double? CropBottom { get; set; }

    [JsonProperty("cropLeft", NullValueHandling = NullValueHandling.Ignore)]
    public double? CropLeft { get; set; }

    [JsonProperty("cropRight", NullValueHandling = NullValueHandling.Ignore)]
    public double? CropRight { get; set; }

    [JsonProperty("cropTop", NullValueHandling = NullValueHandling.Ignore)]
    public double? CropTop { get; set; }

    [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
    public double? Height { get; set; }

    [JsonProperty("positionX", NullValueHandling = NullValueHandling.Ignore)]
    public double? PositionX { get; set; }

    [JsonProperty("positionY", NullValueHandling = NullValueHandling.Ignore)]
    public double? PositionY { get; set; }

    [JsonProperty("rotation", NullValueHandling = NullValueHandling.Ignore)]
    public double? Rotation { get; set; }

    [JsonProperty("scaleX", NullValueHandling = NullValueHandling.Ignore)]
    public double? ScaleX { get; set; }

    [JsonProperty("scaleY", NullValueHandling = NullValueHandling.Ignore)]
    public double? ScaleY { get; set; }

    [JsonProperty("sourceHeight", NullValueHandling = NullValueHandling.Ignore)]
    public double? SourceHeight { get; set; }

    [JsonProperty("sourceWidth", NullValueHandling = NullValueHandling.Ignore)]
    public double? SourceWidth { get; set; }

    [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
    public double? Width { get; set; }
  }

  public struct InputVolumeMeter
  {
    [JsonProperty("inputName", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("inputLevelsMul", NullValueHandling = NullValueHandling.Ignore)]
    public List<double[]> Levels { get; set; }
  }
}
