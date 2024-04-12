using System.Collections.Generic;

using Newtonsoft.Json;

namespace TSO.SB.OBS
{
  public struct Input
  {
    [JsonProperty("inputName")]
    public string InputName { get; set; }

    [JsonProperty("inputKind")]
    public string InputKind { get; set; }

    [JsonProperty("unversionedInputKind")]
    public string UnversionedInputKind { get; set; }
  }

  public struct Output
  {
    [JsonProperty("outputName")]
    public string Name { get; set; }

    [JsonProperty("outputKind")]
    public string Kind { get; set; }

    [JsonProperty("outputWidth")]
    public int Width { get; set; }

    [JsonProperty("outputHeight")]
    public int Height { get; set; }

    [JsonProperty("outputActive")]
    public bool Active { get; set; }

    [JsonProperty("outputFlags")]
    public OutputFlags Flags { get; set; }
  }

  public struct OutputFlags
  {
    [JsonProperty("OBS_OUTPUT_AUDIO")]
    public bool Audio { get; set; }

    [JsonProperty("OBS_OUTPUT_VIDEO")]
    public bool Video { get; set; }

    [JsonProperty("OBS_OUTPUT_ENCODED")]
    public bool Encoded { get; set; }

    [JsonProperty("OBS_OUTPUT_MULTI_TRACK")]
    public bool MultiTrack { get; set; }

    [JsonProperty("OBS_OUTPUT_SERVICE")]
    public bool Service { get; set; }
  }

  public struct Scene
  {
    [JsonProperty("sceneIndex")]
    public int SceneIndex { get; set; }

    [JsonProperty("sceneName")]
    public string SceneName { get; set; }
  }

  public struct PropertyItem
  {
    [JsonProperty("itemName")]
    public string ItemName { get; set; }

    [JsonProperty("itemEnabled")]
    public bool ItemEnabled { get; set; }

    [JsonProperty("itemValue")]
    public object ItemValue { get; set; }
  }

  public struct Filter
  {
    [JsonProperty("filterEnabled")]
    public bool FilterEnabled { get; set; }

    [JsonProperty("filterIndex")]
    public int FilterIndex { get; set; }

    [JsonProperty("filterKind")]
    public string FilterKind { get; set; }

    [JsonProperty("filterName")]
    public string FilterName { get; set; }

    [JsonProperty("filterSettings")]
    public Dictionary<string, object> FilterSettings { get; set; }
  }

  public struct Transition
  {
    [JsonProperty("transitionConfigurable")]
    public bool TransitionConfigurable { get; set; }

    [JsonProperty("transitionFixed")]
    public bool TransitionFixed { get; set; }

    [JsonProperty("transitionKind")]
    public string TransitionKind { get; set; }

    [JsonProperty("transitionName")]
    public string TransitionName { get; set; }
  }

  public struct SceneItemBasic
  {
    [JsonProperty("sceneItemId")]
    public int SceneItemID { get; set; }

    [JsonProperty("sceneItemIndex")]
    public int SceneItemIndex { get; set; }
  }

  public struct SceneItem
  {
    [JsonProperty("inputKind")]
    public string InputKind { get; set; }

    [JsonProperty("isGroup")]
    public bool IsGroup { get; set; }

    [JsonProperty("sceneItemBlendMode")]
    public string SceneItemBlendMode { get; set; }

    [JsonProperty("sceneItemEnabled")]
    public bool SceneItemEnabled { get; set; }

    [JsonProperty("sceneItemId")]
    public int SceneItemID { get; set; }

    [JsonProperty("sceneItemIndex")]
    public int SceneItemIndex { get; set; }

    [JsonProperty("sceneItemLocked")]
    public bool SceneItemLocked { get; set; }

    [JsonProperty("sceneItemTransform")]
    public SceneItemTransform SceneItemTransform { get; set; }

    [JsonProperty("sourceName")]
    public string SourceName { get; set; }

    [JsonProperty("sourceType")]
    public string SourceType { get; set; }
  }

  public class InputAudioTracks : Dictionary<string, bool> { }

  public struct KeyModifiers
  {
    [JsonProperty("face")]
    public string Shift { get; set; }

    [JsonProperty("flags")]
    public int Control { get; set; }

    [JsonProperty("size")]
    public int Alt { get; set; }

    [JsonProperty("style")]
    public string Command { get; set; }
  }

  public struct Monitor
  {
    [JsonProperty("monitorHeight")]
    public int MonitorHeight { get; set; }

    [JsonProperty("monitorIndex")]
    public int MonitorIndex { get; set; }

    [JsonProperty("monitorName")]
    public string MonitorName { get; set; }

    [JsonProperty("monitorPositionX")]
    public int MonitorPositionX { get; set; }

    [JsonProperty("monitorPositionY")]
    public int MonitorPositionY { get; set; }

    [JsonProperty("monitorWidth")]
    public int MonitorWidth { get; set; }
  }

  public struct StreamServiceSettings
  {
    [JsonProperty("bwtest")]
    public bool Bwtest { get; set; }

    [JsonProperty("key")]
    public string Key { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }

    [JsonProperty("server")]
    public string Server { get; set; }

    [JsonProperty("use_auth")]
    public bool UseAuth { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("protocol")]
    public string Protocol { get; set; }
    [JsonProperty("service")]
    public string Service { get; set; }
  }

  public struct SceneItemTransform
  {
    [JsonProperty("alignment")]
    public double Alignment { get; set; }

    [JsonProperty("boundsAlignment")]
    public double BoundsAlignment { get; set; }

    [JsonProperty("boundsHeight")]
    public double BoundsHeight { get; set; }

    [JsonProperty("boundsType")]
    public string BoundsType { get; set; }

    [JsonProperty("boundsWidth")]
    public double BoundsWidth { get; set; }

    [JsonProperty("cropBottom")]
    public double CropBottom { get; set; }

    [JsonProperty("cropLeft")]
    public double CropLeft { get; set; }

    [JsonProperty("cropRight")]
    public double CropRight { get; set; }

    [JsonProperty("cropTop")]
    public double CropTop { get; set; }

    [JsonProperty("height")]
    public double Height { get; set; }

    [JsonProperty("positionX")]
    public double PositionX { get; set; }

    [JsonProperty("positionY")]
    public double PositionY { get; set; }

    [JsonProperty("rotation")]
    public double Rotation { get; set; }

    [JsonProperty("scaleX")]
    public double ScaleX { get; set; }

    [JsonProperty("scaleY")]
    public double ScaleY { get; set; }

    [JsonProperty("sourceHeight")]
    public double SourceHeight { get; set; }

    [JsonProperty("sourceWidth")]
    public double SourceWidth { get; set; }

    [JsonProperty("width")]
    public double Width { get; set; }
  }

  public struct InputVolumeMeter
  {
    [JsonProperty("inputName")]
    public string Name { get; set; }

    [JsonProperty("inputLevelsMul")]
    public List<double[]> Levels { get; set; }
  }
}
