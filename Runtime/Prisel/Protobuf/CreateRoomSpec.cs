// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: prisel/create_room_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Prisel.Protobuf {

  /// <summary>Holder for reflection information generated from prisel/create_room_spec.proto</summary>
  public static partial class CreateRoomSpecReflection {

    #region Descriptor
    /// <summary>File descriptor for prisel/create_room_spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CreateRoomSpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1wcmlzZWwvY3JlYXRlX3Jvb21fc3BlYy5wcm90bxIGcHJpc2VsGhhwcmlz",
            "ZWwvYW5ub3RhdGlvbnMucHJvdG8aFnByaXNlbC9yb29tX2luZm8ucHJvdG8a",
            "IHByaXNlbC9yb29tX3N0YXRlX3NuYXBzaG90LnByb3RvIi8KEUNyZWF0ZVJv",
            "b21SZXF1ZXN0EhAKCHJvb21OYW1lGAEgASgJOgiStRgECAQQASJtChJDcmVh",
            "dGVSb29tUmVzcG9uc2USHgoEcm9vbRgBIAEoCzIQLnByaXNlbC5Sb29tSW5m",
            "bxItCgpyb29tX3N0YXRlGAIgASgLMhkucHJpc2VsLlJvb21TdGF0ZVNuYXBz",
            "aG90OgiStRgECAQQAkISqgIPUHJpc2VsLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Prisel.Protobuf.AnnotationsReflection.Descriptor, global::Prisel.Protobuf.RoomInfoReflection.Descriptor, global::Prisel.Protobuf.RoomStateSnapshotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Prisel.Protobuf.CreateRoomRequest), global::Prisel.Protobuf.CreateRoomRequest.Parser, new[]{ "RoomName" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Prisel.Protobuf.CreateRoomResponse), global::Prisel.Protobuf.CreateRoomResponse.Parser, new[]{ "Room", "RoomState" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CreateRoomRequest : pb::IMessage<CreateRoomRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateRoomRequest> _parser = new pb::MessageParser<CreateRoomRequest>(() => new CreateRoomRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateRoomRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Prisel.Protobuf.CreateRoomSpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoomRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoomRequest(CreateRoomRequest other) : this() {
      roomName_ = other.roomName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoomRequest Clone() {
      return new CreateRoomRequest(this);
    }

    /// <summary>Field number for the "roomName" field.</summary>
    public const int RoomNameFieldNumber = 1;
    private string roomName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomName {
      get { return roomName_; }
      set {
        roomName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateRoomRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateRoomRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomName != other.RoomName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomName.Length != 0) hash ^= RoomName.GetHashCode();
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
      if (RoomName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RoomName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (RoomName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RoomName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateRoomRequest other) {
      if (other == null) {
        return;
      }
      if (other.RoomName.Length != 0) {
        RoomName = other.RoomName;
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
            RoomName = input.ReadString();
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
            RoomName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CreateRoomResponse : pb::IMessage<CreateRoomResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateRoomResponse> _parser = new pb::MessageParser<CreateRoomResponse>(() => new CreateRoomResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateRoomResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Prisel.Protobuf.CreateRoomSpecReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoomResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoomResponse(CreateRoomResponse other) : this() {
      room_ = other.room_ != null ? other.room_.Clone() : null;
      roomState_ = other.roomState_ != null ? other.roomState_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateRoomResponse Clone() {
      return new CreateRoomResponse(this);
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 1;
    private global::Prisel.Protobuf.RoomInfo room_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Prisel.Protobuf.RoomInfo Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    /// <summary>Field number for the "room_state" field.</summary>
    public const int RoomStateFieldNumber = 2;
    private global::Prisel.Protobuf.RoomStateSnapshot roomState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Prisel.Protobuf.RoomStateSnapshot RoomState {
      get { return roomState_; }
      set {
        roomState_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateRoomResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateRoomResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Room, other.Room)) return false;
      if (!object.Equals(RoomState, other.RoomState)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (room_ != null) hash ^= Room.GetHashCode();
      if (roomState_ != null) hash ^= RoomState.GetHashCode();
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
      if (room_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Room);
      }
      if (roomState_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RoomState);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (room_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Room);
      }
      if (roomState_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(RoomState);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      if (roomState_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoomState);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateRoomResponse other) {
      if (other == null) {
        return;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          Room = new global::Prisel.Protobuf.RoomInfo();
        }
        Room.MergeFrom(other.Room);
      }
      if (other.roomState_ != null) {
        if (roomState_ == null) {
          RoomState = new global::Prisel.Protobuf.RoomStateSnapshot();
        }
        RoomState.MergeFrom(other.RoomState);
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
            if (room_ == null) {
              Room = new global::Prisel.Protobuf.RoomInfo();
            }
            input.ReadMessage(Room);
            break;
          }
          case 18: {
            if (roomState_ == null) {
              RoomState = new global::Prisel.Protobuf.RoomStateSnapshot();
            }
            input.ReadMessage(RoomState);
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
            if (room_ == null) {
              Room = new global::Prisel.Protobuf.RoomInfo();
            }
            input.ReadMessage(Room);
            break;
          }
          case 18: {
            if (roomState_ == null) {
              RoomState = new global::Prisel.Protobuf.RoomStateSnapshot();
            }
            input.ReadMessage(RoomState);
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