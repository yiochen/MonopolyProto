// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: monopoly/announce_end_turn_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Monopoly.Protobuf {

  /// <summary>Holder for reflection information generated from monopoly/announce_end_turn_spec.proto</summary>
  public static partial class AnnounceEndTurnSpecReflection {

    #region Descriptor
    /// <summary>File descriptor for monopoly/announce_end_turn_spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnounceEndTurnSpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVtb25vcG9seS9hbm5vdW5jZV9lbmRfdHVybl9zcGVjLnByb3RvEghtb25v",
            "cG9seRoYcHJpc2VsL2Fubm90YXRpb25zLnByb3RvIl4KFkFubm91bmNlRW5k",
            "VHVyblBheWxvYWQSFgoOY3VycmVudF9wbGF5ZXIYASABKAkSEwoLbmV4dF9w",
            "bGF5ZXIYAiABKAk6F5q1GBMKEWFubm91bmNlX2VuZF90dXJuQhSqAhFNb25v",
            "cG9seS5Qcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Prisel.Protobuf.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Monopoly.Protobuf.AnnounceEndTurnPayload), global::Monopoly.Protobuf.AnnounceEndTurnPayload.Parser, new[]{ "CurrentPlayer", "NextPlayer" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AnnounceEndTurnPayload : pb::IMessage<AnnounceEndTurnPayload>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnnounceEndTurnPayload> _parser = new pb::MessageParser<AnnounceEndTurnPayload>(() => new AnnounceEndTurnPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnnounceEndTurnPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Monopoly.Protobuf.AnnounceEndTurnSpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnounceEndTurnPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnounceEndTurnPayload(AnnounceEndTurnPayload other) : this() {
      currentPlayer_ = other.currentPlayer_;
      nextPlayer_ = other.nextPlayer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnounceEndTurnPayload Clone() {
      return new AnnounceEndTurnPayload(this);
    }

    /// <summary>Field number for the "current_player" field.</summary>
    public const int CurrentPlayerFieldNumber = 1;
    private string currentPlayer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrentPlayer {
      get { return currentPlayer_; }
      set {
        currentPlayer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "next_player" field.</summary>
    public const int NextPlayerFieldNumber = 2;
    private string nextPlayer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPlayer {
      get { return nextPlayer_; }
      set {
        nextPlayer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnnounceEndTurnPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnnounceEndTurnPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentPlayer != other.CurrentPlayer) return false;
      if (NextPlayer != other.NextPlayer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentPlayer.Length != 0) hash ^= CurrentPlayer.GetHashCode();
      if (NextPlayer.Length != 0) hash ^= NextPlayer.GetHashCode();
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
      if (CurrentPlayer.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrentPlayer);
      }
      if (NextPlayer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPlayer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CurrentPlayer.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrentPlayer);
      }
      if (NextPlayer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPlayer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentPlayer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrentPlayer);
      }
      if (NextPlayer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPlayer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnnounceEndTurnPayload other) {
      if (other == null) {
        return;
      }
      if (other.CurrentPlayer.Length != 0) {
        CurrentPlayer = other.CurrentPlayer;
      }
      if (other.NextPlayer.Length != 0) {
        NextPlayer = other.NextPlayer;
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
            CurrentPlayer = input.ReadString();
            break;
          }
          case 18: {
            NextPlayer = input.ReadString();
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
            CurrentPlayer = input.ReadString();
            break;
          }
          case 18: {
            NextPlayer = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
