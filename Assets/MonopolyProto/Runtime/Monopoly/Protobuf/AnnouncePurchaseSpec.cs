// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: monopoly/announce_purchase_spec.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Monopoly.Protobuf {

  /// <summary>Holder for reflection information generated from monopoly/announce_purchase_spec.proto</summary>
  public static partial class AnnouncePurchaseSpecReflection {

    #region Descriptor
    /// <summary>File descriptor for monopoly/announce_purchase_spec.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnouncePurchaseSpecReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVtb25vcG9seS9hbm5vdW5jZV9wdXJjaGFzZV9zcGVjLnByb3RvEghtb25v",
            "cG9seRoXbW9ub3BvbHkvcHJvcGVydHkucHJvdG8iUwoXQW5ub3VuY2VQdXJj",
            "aGFzZVBheWxvYWQSDgoGcGxheWVyGAEgASgJEigKCHByb3BlcnR5GAIgASgL",
            "MhYubW9ub3BvbHkuUHJvcGVydHlJbmZvQhSqAhFNb25vcG9seS5Qcm90b2J1",
            "ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Monopoly.Protobuf.PropertyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Monopoly.Protobuf.AnnouncePurchasePayload), global::Monopoly.Protobuf.AnnouncePurchasePayload.Parser, new[]{ "Player", "Property" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// type : "announce_purchase"
  /// packet_type : DEFAULT
  /// </summary>
  public sealed partial class AnnouncePurchasePayload : pb::IMessage<AnnouncePurchasePayload>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AnnouncePurchasePayload> _parser = new pb::MessageParser<AnnouncePurchasePayload>(() => new AnnouncePurchasePayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnnouncePurchasePayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Monopoly.Protobuf.AnnouncePurchaseSpecReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnouncePurchasePayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnouncePurchasePayload(AnnouncePurchasePayload other) : this() {
      player_ = other.player_;
      property_ = other.property_ != null ? other.property_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnnouncePurchasePayload Clone() {
      return new AnnouncePurchasePayload(this);
    }

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 1;
    private string player_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Player {
      get { return player_; }
      set {
        player_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "property" field.</summary>
    public const int PropertyFieldNumber = 2;
    private global::Monopoly.Protobuf.PropertyInfo property_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Monopoly.Protobuf.PropertyInfo Property {
      get { return property_; }
      set {
        property_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnnouncePurchasePayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnnouncePurchasePayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Player != other.Player) return false;
      if (!object.Equals(Property, other.Property)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Player.Length != 0) hash ^= Player.GetHashCode();
      if (property_ != null) hash ^= Property.GetHashCode();
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
      if (Player.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Player);
      }
      if (property_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Property);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Player.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Player);
      }
      if (property_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Property);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Player.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Player);
      }
      if (property_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Property);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AnnouncePurchasePayload other) {
      if (other == null) {
        return;
      }
      if (other.Player.Length != 0) {
        Player = other.Player;
      }
      if (other.property_ != null) {
        if (property_ == null) {
          Property = new global::Monopoly.Protobuf.PropertyInfo();
        }
        Property.MergeFrom(other.Property);
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
            Player = input.ReadString();
            break;
          }
          case 18: {
            if (property_ == null) {
              Property = new global::Monopoly.Protobuf.PropertyInfo();
            }
            input.ReadMessage(Property);
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
            Player = input.ReadString();
            break;
          }
          case 18: {
            if (property_ == null) {
              Property = new global::Monopoly.Protobuf.PropertyInfo();
            }
            input.ReadMessage(Property);
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
