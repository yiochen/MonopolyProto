// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: prisel/get_room_state_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Prisel.Protobuf {

  /// <summary>Holder for reflection information generated from prisel/get_room_state_spec.proto</summary>
  public static partial class GetRoomStateSpecReflection {

    #region Descriptor
    /// <summary>File descriptor for prisel/get_room_state_spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetRoomStateSpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBwcmlzZWwvZ2V0X3Jvb21fc3RhdGVfc3BlYy5wcm90bxIGcHJpc2VsGhhw",
            "cmlzZWwvYW5ub3RhdGlvbnMucHJvdG8aGHByaXNlbC9wbGF5ZXJfaW5mby5w",
            "cm90byJ2ChRHZXRSb29tU3RhdGVSZXNwb25zZRIjCgdwbGF5ZXJzGAEgAygL",
            "MhIucHJpc2VsLlBsYXllckluZm8SFAoHaG9zdF9pZBgCIAEoCUgAiAEBEg0K",
            "BXRva2VuGAMgASgJOgiStRgECA0QAkIKCghfaG9zdF9pZEISqgIPUHJpc2Vs",
            "LlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Prisel.Protobuf.AnnotationsReflection.Descriptor, global::Prisel.Protobuf.PlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Prisel.Protobuf.GetRoomStateResponse), global::Prisel.Protobuf.GetRoomStateResponse.Parser, new[]{ "Players", "HostId", "Token" }, new[]{ "HostId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetRoomStateResponse : pb::IMessage<GetRoomStateResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetRoomStateResponse> _parser = new pb::MessageParser<GetRoomStateResponse>(() => new GetRoomStateResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetRoomStateResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Prisel.Protobuf.GetRoomStateSpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRoomStateResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRoomStateResponse(GetRoomStateResponse other) : this() {
      players_ = other.players_.Clone();
      hostId_ = other.hostId_;
      token_ = other.token_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetRoomStateResponse Clone() {
      return new GetRoomStateResponse(this);
    }

    /// <summary>Field number for the "players" field.</summary>
    public const int PlayersFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Prisel.Protobuf.PlayerInfo> _repeated_players_codec
        = pb::FieldCodec.ForMessage(10, global::Prisel.Protobuf.PlayerInfo.Parser);
    private readonly pbc::RepeatedField<global::Prisel.Protobuf.PlayerInfo> players_ = new pbc::RepeatedField<global::Prisel.Protobuf.PlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Prisel.Protobuf.PlayerInfo> Players {
      get { return players_; }
    }

    /// <summary>Field number for the "host_id" field.</summary>
    public const int HostIdFieldNumber = 2;
    private string hostId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HostId {
      get { return hostId_ ?? ""; }
      set {
        hostId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "host_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasHostId {
      get { return hostId_ != null; }
    }
    /// <summary>Clears the value of the "host_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearHostId() {
      hostId_ = null;
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 3;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetRoomStateResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetRoomStateResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!players_.Equals(other.players_)) return false;
      if (HostId != other.HostId) return false;
      if (Token != other.Token) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= players_.GetHashCode();
      if (HasHostId) hash ^= HostId.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
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
      players_.WriteTo(output, _repeated_players_codec);
      if (HasHostId) {
        output.WriteRawTag(18);
        output.WriteString(HostId);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Token);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      players_.WriteTo(ref output, _repeated_players_codec);
      if (HasHostId) {
        output.WriteRawTag(18);
        output.WriteString(HostId);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Token);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += players_.CalculateSize(_repeated_players_codec);
      if (HasHostId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HostId);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetRoomStateResponse other) {
      if (other == null) {
        return;
      }
      players_.Add(other.players_);
      if (other.HasHostId) {
        HostId = other.HostId;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
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
            players_.AddEntriesFrom(input, _repeated_players_codec);
            break;
          }
          case 18: {
            HostId = input.ReadString();
            break;
          }
          case 26: {
            Token = input.ReadString();
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
            players_.AddEntriesFrom(ref input, _repeated_players_codec);
            break;
          }
          case 18: {
            HostId = input.ReadString();
            break;
          }
          case 26: {
            Token = input.ReadString();
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
