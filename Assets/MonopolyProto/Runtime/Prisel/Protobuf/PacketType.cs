// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: prisel/packet_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Prisel.Protobuf {

  /// <summary>Holder for reflection information generated from prisel/packet_type.proto</summary>
  public static partial class PacketTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for prisel/packet_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PacketTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhwcmlzZWwvcGFja2V0X3R5cGUucHJvdG8SBnByaXNlbCo0CgpQYWNrZXRU",
            "eXBlEgsKB0RFRkFVTFQQABILCgdSRVFVRVNUEAESDAoIUkVTUE9OU0UQAkIS",
            "qgIPUHJpc2VsLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Prisel.Protobuf.PacketType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum PacketType {
    [pbr::OriginalName("DEFAULT")] Default = 0,
    [pbr::OriginalName("REQUEST")] Request = 1,
    [pbr::OriginalName("RESPONSE")] Response = 2,
  }

  #endregion

}

#endregion Designer generated code
