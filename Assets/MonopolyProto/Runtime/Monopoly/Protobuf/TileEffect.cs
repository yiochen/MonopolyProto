// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: monopoly/tile_effect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Monopoly.Protobuf {

  /// <summary>Holder for reflection information generated from monopoly/tile_effect.proto</summary>
  public static partial class TileEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for monopoly/tile_effect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TileEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chptb25vcG9seS90aWxlX2VmZmVjdC5wcm90bxIIbW9ub3BvbHkaIW1vbm9w",
            "b2x5L21vdmVfdG9fdGlsZV9leHRyYS5wcm90bxojbW9ub3BvbHkvbW9uZXlf",
            "ZXhjaGFuZ2VfZXh0cmEucHJvdG8aH21vbm9wb2x5L21vdmVfc3RlcHNfZXh0",
            "cmEucHJvdG8aIG1vbm9wb2x5L2NvbGxlY3RpYmxlX2V4dHJhLnByb3RvGh1t",
            "b25vcG9seS9kZXRhaW5lZF9leHRyYS5wcm90byI3ChFUaWxlRWZmZWN0RGlz",
            "cGxheRINCgV0aXRsZRgBIAEoCRITCgtkZXNjcmlwdGlvbhgCIAEoCSLGAwoK",
            "VGlsZUVmZmVjdBIsCgdkaXNwbGF5GAEgASgLMhsubW9ub3BvbHkuVGlsZUVm",
            "ZmVjdERpc3BsYXkSKwoGdGltaW5nGAIgASgOMhsubW9ub3BvbHkuVGlsZUVm",
            "ZmVjdC5UaW1pbmcSFQoLdW5zcGVjaWZpZWQYAyABKAhIABIxCgxtb3ZlX3Rv",
            "X3RpbGUYBCABKAsyGS5tb25vcG9seS5Nb3ZlVG9UaWxlRXh0cmFIABI2Cg5t",
            "b25leV9leGNoYW5nZRgFIAEoCzIcLm1vbm9wb2x5Lk1vbmV5RXhjaGFuZ2VF",
            "eHRyYUgAEi4KCm1vdmVfc3RlcHMYBiABKAsyGC5tb25vcG9seS5Nb3ZlU3Rl",
            "cHNFeHRyYUgAEjEKC2NvbGxlY3RpYmxlGAcgASgLMhoubW9ub3BvbHkuQ29s",
            "bGVjdGlibGVFeHRyYUgAEisKCGRldGFpbmVkGAggASgLMhcubW9ub3BvbHku",
            "RGV0YWluZWRFeHRyYUgAIkIKBlRpbWluZxIPCgtVTlNQRUNJRklFRBAAEgwK",
            "CEVOVEVSSU5HEAESDAoIU1RPUFBJTkcQAhILCgdMRUFWSU5HEANCBwoFZXh0",
            "cmFCFKoCEU1vbm9wb2x5LlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Monopoly.Protobuf.MoveToTileExtraReflection.Descriptor, global::Monopoly.Protobuf.MoneyExchangeExtraReflection.Descriptor, global::Monopoly.Protobuf.MoveStepsExtraReflection.Descriptor, global::Monopoly.Protobuf.CollectibleExtraReflection.Descriptor, global::Monopoly.Protobuf.DetainedExtraReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Monopoly.Protobuf.TileEffectDisplay), global::Monopoly.Protobuf.TileEffectDisplay.Parser, new[]{ "Title", "Description" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Monopoly.Protobuf.TileEffect), global::Monopoly.Protobuf.TileEffect.Parser, new[]{ "Display", "Timing", "Unspecified", "MoveToTile", "MoneyExchange", "MoveSteps", "Collectible", "Detained" }, new[]{ "Extra" }, new[]{ typeof(global::Monopoly.Protobuf.TileEffect.Types.Timing) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// TileEffect is effect that player will take when entering/leaving/stoping at a
  /// tile.
  /// </summary>
  public sealed partial class TileEffectDisplay : pb::IMessage<TileEffectDisplay>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TileEffectDisplay> _parser = new pb::MessageParser<TileEffectDisplay>(() => new TileEffectDisplay());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TileEffectDisplay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Monopoly.Protobuf.TileEffectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TileEffectDisplay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TileEffectDisplay(TileEffectDisplay other) : this() {
      title_ = other.title_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TileEffectDisplay Clone() {
      return new TileEffectDisplay(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TileEffectDisplay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TileEffectDisplay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TileEffectDisplay other) {
      if (other == null) {
        return;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TileEffect : pb::IMessage<TileEffect>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TileEffect> _parser = new pb::MessageParser<TileEffect>(() => new TileEffect());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TileEffect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Monopoly.Protobuf.TileEffectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TileEffect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TileEffect(TileEffect other) : this() {
      display_ = other.display_ != null ? other.display_.Clone() : null;
      timing_ = other.timing_;
      switch (other.ExtraCase) {
        case ExtraOneofCase.Unspecified:
          Unspecified = other.Unspecified;
          break;
        case ExtraOneofCase.MoveToTile:
          MoveToTile = other.MoveToTile.Clone();
          break;
        case ExtraOneofCase.MoneyExchange:
          MoneyExchange = other.MoneyExchange.Clone();
          break;
        case ExtraOneofCase.MoveSteps:
          MoveSteps = other.MoveSteps.Clone();
          break;
        case ExtraOneofCase.Collectible:
          Collectible = other.Collectible.Clone();
          break;
        case ExtraOneofCase.Detained:
          Detained = other.Detained.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TileEffect Clone() {
      return new TileEffect(this);
    }

    /// <summary>Field number for the "display" field.</summary>
    public const int DisplayFieldNumber = 1;
    private global::Monopoly.Protobuf.TileEffectDisplay display_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.TileEffectDisplay Display {
      get { return display_; }
      set {
        display_ = value;
      }
    }

    /// <summary>Field number for the "timing" field.</summary>
    public const int TimingFieldNumber = 2;
    private global::Monopoly.Protobuf.TileEffect.Types.Timing timing_ = global::Monopoly.Protobuf.TileEffect.Types.Timing.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.TileEffect.Types.Timing Timing {
      get { return timing_; }
      set {
        timing_ = value;
      }
    }

    /// <summary>Field number for the "unspecified" field.</summary>
    public const int UnspecifiedFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Unspecified {
      get { return extraCase_ == ExtraOneofCase.Unspecified ? (bool) extra_ : false; }
      set {
        extra_ = value;
        extraCase_ = ExtraOneofCase.Unspecified;
      }
    }

    /// <summary>Field number for the "move_to_tile" field.</summary>
    public const int MoveToTileFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.MoveToTileExtra MoveToTile {
      get { return extraCase_ == ExtraOneofCase.MoveToTile ? (global::Monopoly.Protobuf.MoveToTileExtra) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.MoveToTile;
      }
    }

    /// <summary>Field number for the "money_exchange" field.</summary>
    public const int MoneyExchangeFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.MoneyExchangeExtra MoneyExchange {
      get { return extraCase_ == ExtraOneofCase.MoneyExchange ? (global::Monopoly.Protobuf.MoneyExchangeExtra) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.MoneyExchange;
      }
    }

    /// <summary>Field number for the "move_steps" field.</summary>
    public const int MoveStepsFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.MoveStepsExtra MoveSteps {
      get { return extraCase_ == ExtraOneofCase.MoveSteps ? (global::Monopoly.Protobuf.MoveStepsExtra) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.MoveSteps;
      }
    }

    /// <summary>Field number for the "collectible" field.</summary>
    public const int CollectibleFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.CollectibleExtra Collectible {
      get { return extraCase_ == ExtraOneofCase.Collectible ? (global::Monopoly.Protobuf.CollectibleExtra) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.Collectible;
      }
    }

    /// <summary>Field number for the "detained" field.</summary>
    public const int DetainedFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.DetainedExtra Detained {
      get { return extraCase_ == ExtraOneofCase.Detained ? (global::Monopoly.Protobuf.DetainedExtra) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.Detained;
      }
    }

    private object extra_;
    /// <summary>Enum of possible cases for the "extra" oneof.</summary>
    public enum ExtraOneofCase {
      None = 0,
      Unspecified = 3,
      MoveToTile = 4,
      MoneyExchange = 5,
      MoveSteps = 6,
      Collectible = 7,
      Detained = 8,
    }
    private ExtraOneofCase extraCase_ = ExtraOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtraOneofCase ExtraCase {
      get { return extraCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearExtra() {
      extraCase_ = ExtraOneofCase.None;
      extra_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TileEffect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TileEffect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Display, other.Display)) return false;
      if (Timing != other.Timing) return false;
      if (Unspecified != other.Unspecified) return false;
      if (!object.Equals(MoveToTile, other.MoveToTile)) return false;
      if (!object.Equals(MoneyExchange, other.MoneyExchange)) return false;
      if (!object.Equals(MoveSteps, other.MoveSteps)) return false;
      if (!object.Equals(Collectible, other.Collectible)) return false;
      if (!object.Equals(Detained, other.Detained)) return false;
      if (ExtraCase != other.ExtraCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (display_ != null) hash ^= Display.GetHashCode();
      if (Timing != global::Monopoly.Protobuf.TileEffect.Types.Timing.Unspecified) hash ^= Timing.GetHashCode();
      if (extraCase_ == ExtraOneofCase.Unspecified) hash ^= Unspecified.GetHashCode();
      if (extraCase_ == ExtraOneofCase.MoveToTile) hash ^= MoveToTile.GetHashCode();
      if (extraCase_ == ExtraOneofCase.MoneyExchange) hash ^= MoneyExchange.GetHashCode();
      if (extraCase_ == ExtraOneofCase.MoveSteps) hash ^= MoveSteps.GetHashCode();
      if (extraCase_ == ExtraOneofCase.Collectible) hash ^= Collectible.GetHashCode();
      if (extraCase_ == ExtraOneofCase.Detained) hash ^= Detained.GetHashCode();
      hash ^= (int) extraCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (display_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Display);
      }
      if (Timing != global::Monopoly.Protobuf.TileEffect.Types.Timing.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Timing);
      }
      if (extraCase_ == ExtraOneofCase.Unspecified) {
        output.WriteRawTag(24);
        output.WriteBool(Unspecified);
      }
      if (extraCase_ == ExtraOneofCase.MoveToTile) {
        output.WriteRawTag(34);
        output.WriteMessage(MoveToTile);
      }
      if (extraCase_ == ExtraOneofCase.MoneyExchange) {
        output.WriteRawTag(42);
        output.WriteMessage(MoneyExchange);
      }
      if (extraCase_ == ExtraOneofCase.MoveSteps) {
        output.WriteRawTag(50);
        output.WriteMessage(MoveSteps);
      }
      if (extraCase_ == ExtraOneofCase.Collectible) {
        output.WriteRawTag(58);
        output.WriteMessage(Collectible);
      }
      if (extraCase_ == ExtraOneofCase.Detained) {
        output.WriteRawTag(66);
        output.WriteMessage(Detained);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (display_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Display);
      }
      if (Timing != global::Monopoly.Protobuf.TileEffect.Types.Timing.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Timing);
      }
      if (extraCase_ == ExtraOneofCase.Unspecified) {
        output.WriteRawTag(24);
        output.WriteBool(Unspecified);
      }
      if (extraCase_ == ExtraOneofCase.MoveToTile) {
        output.WriteRawTag(34);
        output.WriteMessage(MoveToTile);
      }
      if (extraCase_ == ExtraOneofCase.MoneyExchange) {
        output.WriteRawTag(42);
        output.WriteMessage(MoneyExchange);
      }
      if (extraCase_ == ExtraOneofCase.MoveSteps) {
        output.WriteRawTag(50);
        output.WriteMessage(MoveSteps);
      }
      if (extraCase_ == ExtraOneofCase.Collectible) {
        output.WriteRawTag(58);
        output.WriteMessage(Collectible);
      }
      if (extraCase_ == ExtraOneofCase.Detained) {
        output.WriteRawTag(66);
        output.WriteMessage(Detained);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (display_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Display);
      }
      if (Timing != global::Monopoly.Protobuf.TileEffect.Types.Timing.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Timing);
      }
      if (extraCase_ == ExtraOneofCase.Unspecified) {
        size += 1 + 1;
      }
      if (extraCase_ == ExtraOneofCase.MoveToTile) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveToTile);
      }
      if (extraCase_ == ExtraOneofCase.MoneyExchange) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoneyExchange);
      }
      if (extraCase_ == ExtraOneofCase.MoveSteps) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveSteps);
      }
      if (extraCase_ == ExtraOneofCase.Collectible) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Collectible);
      }
      if (extraCase_ == ExtraOneofCase.Detained) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Detained);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TileEffect other) {
      if (other == null) {
        return;
      }
      if (other.display_ != null) {
        if (display_ == null) {
          Display = new global::Monopoly.Protobuf.TileEffectDisplay();
        }
        Display.MergeFrom(other.Display);
      }
      if (other.Timing != global::Monopoly.Protobuf.TileEffect.Types.Timing.Unspecified) {
        Timing = other.Timing;
      }
      switch (other.ExtraCase) {
        case ExtraOneofCase.Unspecified:
          Unspecified = other.Unspecified;
          break;
        case ExtraOneofCase.MoveToTile:
          if (MoveToTile == null) {
            MoveToTile = new global::Monopoly.Protobuf.MoveToTileExtra();
          }
          MoveToTile.MergeFrom(other.MoveToTile);
          break;
        case ExtraOneofCase.MoneyExchange:
          if (MoneyExchange == null) {
            MoneyExchange = new global::Monopoly.Protobuf.MoneyExchangeExtra();
          }
          MoneyExchange.MergeFrom(other.MoneyExchange);
          break;
        case ExtraOneofCase.MoveSteps:
          if (MoveSteps == null) {
            MoveSteps = new global::Monopoly.Protobuf.MoveStepsExtra();
          }
          MoveSteps.MergeFrom(other.MoveSteps);
          break;
        case ExtraOneofCase.Collectible:
          if (Collectible == null) {
            Collectible = new global::Monopoly.Protobuf.CollectibleExtra();
          }
          Collectible.MergeFrom(other.Collectible);
          break;
        case ExtraOneofCase.Detained:
          if (Detained == null) {
            Detained = new global::Monopoly.Protobuf.DetainedExtra();
          }
          Detained.MergeFrom(other.Detained);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (display_ == null) {
              Display = new global::Monopoly.Protobuf.TileEffectDisplay();
            }
            input.ReadMessage(Display);
            break;
          }
          case 16: {
            Timing = (global::Monopoly.Protobuf.TileEffect.Types.Timing) input.ReadEnum();
            break;
          }
          case 24: {
            Unspecified = input.ReadBool();
            break;
          }
          case 34: {
            global::Monopoly.Protobuf.MoveToTileExtra subBuilder = new global::Monopoly.Protobuf.MoveToTileExtra();
            if (extraCase_ == ExtraOneofCase.MoveToTile) {
              subBuilder.MergeFrom(MoveToTile);
            }
            input.ReadMessage(subBuilder);
            MoveToTile = subBuilder;
            break;
          }
          case 42: {
            global::Monopoly.Protobuf.MoneyExchangeExtra subBuilder = new global::Monopoly.Protobuf.MoneyExchangeExtra();
            if (extraCase_ == ExtraOneofCase.MoneyExchange) {
              subBuilder.MergeFrom(MoneyExchange);
            }
            input.ReadMessage(subBuilder);
            MoneyExchange = subBuilder;
            break;
          }
          case 50: {
            global::Monopoly.Protobuf.MoveStepsExtra subBuilder = new global::Monopoly.Protobuf.MoveStepsExtra();
            if (extraCase_ == ExtraOneofCase.MoveSteps) {
              subBuilder.MergeFrom(MoveSteps);
            }
            input.ReadMessage(subBuilder);
            MoveSteps = subBuilder;
            break;
          }
          case 58: {
            global::Monopoly.Protobuf.CollectibleExtra subBuilder = new global::Monopoly.Protobuf.CollectibleExtra();
            if (extraCase_ == ExtraOneofCase.Collectible) {
              subBuilder.MergeFrom(Collectible);
            }
            input.ReadMessage(subBuilder);
            Collectible = subBuilder;
            break;
          }
          case 66: {
            global::Monopoly.Protobuf.DetainedExtra subBuilder = new global::Monopoly.Protobuf.DetainedExtra();
            if (extraCase_ == ExtraOneofCase.Detained) {
              subBuilder.MergeFrom(Detained);
            }
            input.ReadMessage(subBuilder);
            Detained = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (display_ == null) {
              Display = new global::Monopoly.Protobuf.TileEffectDisplay();
            }
            input.ReadMessage(Display);
            break;
          }
          case 16: {
            Timing = (global::Monopoly.Protobuf.TileEffect.Types.Timing) input.ReadEnum();
            break;
          }
          case 24: {
            Unspecified = input.ReadBool();
            break;
          }
          case 34: {
            global::Monopoly.Protobuf.MoveToTileExtra subBuilder = new global::Monopoly.Protobuf.MoveToTileExtra();
            if (extraCase_ == ExtraOneofCase.MoveToTile) {
              subBuilder.MergeFrom(MoveToTile);
            }
            input.ReadMessage(subBuilder);
            MoveToTile = subBuilder;
            break;
          }
          case 42: {
            global::Monopoly.Protobuf.MoneyExchangeExtra subBuilder = new global::Monopoly.Protobuf.MoneyExchangeExtra();
            if (extraCase_ == ExtraOneofCase.MoneyExchange) {
              subBuilder.MergeFrom(MoneyExchange);
            }
            input.ReadMessage(subBuilder);
            MoneyExchange = subBuilder;
            break;
          }
          case 50: {
            global::Monopoly.Protobuf.MoveStepsExtra subBuilder = new global::Monopoly.Protobuf.MoveStepsExtra();
            if (extraCase_ == ExtraOneofCase.MoveSteps) {
              subBuilder.MergeFrom(MoveSteps);
            }
            input.ReadMessage(subBuilder);
            MoveSteps = subBuilder;
            break;
          }
          case 58: {
            global::Monopoly.Protobuf.CollectibleExtra subBuilder = new global::Monopoly.Protobuf.CollectibleExtra();
            if (extraCase_ == ExtraOneofCase.Collectible) {
              subBuilder.MergeFrom(Collectible);
            }
            input.ReadMessage(subBuilder);
            Collectible = subBuilder;
            break;
          }
          case 66: {
            global::Monopoly.Protobuf.DetainedExtra subBuilder = new global::Monopoly.Protobuf.DetainedExtra();
            if (extraCase_ == ExtraOneofCase.Detained) {
              subBuilder.MergeFrom(Detained);
            }
            input.ReadMessage(subBuilder);
            Detained = subBuilder;
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TileEffect message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Timing {
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Effect activates when entering the tile. Even if player would stop at
        /// this tile, the effect activates before any user actions at this tile (pay
        /// rent, purchase land, etc.)
        /// </summary>
        [pbr::OriginalName("ENTERING")] Entering = 1,
        /// <summary>
        /// Effect activates when stopping at the tile. The effect activates before
        /// any user actions at this tile (pay rent, purchase land, etc.)
        /// </summary>
        [pbr::OriginalName("STOPPING")] Stopping = 2,
        /// <summary>
        /// Effect activates when leaving this tile. Either before player starts
        /// moving on a new turn, or when player passing this tile.
        /// </summary>
        [pbr::OriginalName("LEAVING")] Leaving = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
