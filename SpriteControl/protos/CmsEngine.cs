// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protos/cmsEngine.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.CmsEngine.Grpc {

  /// <summary>Holder for reflection information generated from protos/cmsEngine.proto</summary>
  public static partial class CmsEngineReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/cmsEngine.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CmsEngineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZwcm90b3MvY21zRW5naW5lLnByb3RvEhJjb20uY21zRW5naW5lLmdycGMi",
            "EwoFSWRlbnQSCgoCaWQYASABKAkiJgoFUGFyYW0SDAoEbUtleRgBIAEoCRIP",
            "CgdtVmFsdWVzGAMgAygJIjkKBUVsbW50EgoKAmlkGAEgASgJEiQKAXAYAiAD",
            "KAsyGS5jb20uY21zRW5naW5lLmdycGMuUGFyYW0iNgoJRWxtbnRMaXN0EikK",
            "BmVsbW50cxgBIAMoCzIZLmNvbS5jbXNFbmdpbmUuZ3JwYy5FbG1udCIJCgdS",
            "cGNWb2lkMu0EChBDbXNFbmdpbmVTZXJ2aWNlEkAKBHBpbmcSGy5jb20uY21z",
            "RW5naW5lLmdycGMuUnBjVm9pZBobLmNvbS5jbXNFbmdpbmUuZ3JwYy5ScGNW",
            "b2lkEjsKA2dldBIZLmNvbS5jbXNFbmdpbmUuZ3JwYy5JZGVudBoZLmNvbS5j",
            "bXNFbmdpbmUuZ3JwYy5FbG1udBJECgZnZXRBbGwSGy5jb20uY21zRW5naW5l",
            "LmdycGMuUnBjVm9pZBodLmNvbS5jbXNFbmdpbmUuZ3JwYy5FbG1udExpc3QS",
            "PQoDcHV0EhkuY29tLmNtc0VuZ2luZS5ncnBjLkVsbW50GhsuY29tLmNtc0Vu",
            "Z2luZS5ncnBjLlJwY1ZvaWQSQgoIcHV0QnlLZXkSGS5jb20uY21zRW5naW5l",
            "LmdycGMuRWxtbnQaGy5jb20uY21zRW5naW5lLmdycGMuUnBjVm9pZBI+CgRw",
            "b3N0EhkuY29tLmNtc0VuZ2luZS5ncnBjLkVsbW50GhsuY29tLmNtc0VuZ2lu",
            "ZS5ncnBjLlJwY1ZvaWQSQQoHZGVzdHJveRIZLmNvbS5jbXNFbmdpbmUuZ3Jw",
            "Yy5JZGVudBobLmNvbS5jbXNFbmdpbmUuZ3JwYy5ScGNWb2lkEkEKBWNsZWFy",
            "EhsuY29tLmNtc0VuZ2luZS5ncnBjLlJwY1ZvaWQaGy5jb20uY21zRW5naW5l",
            "LmdycGMuUnBjVm9pZBJLChFnZXRPbmVFbG1udFN0cmVhbRIZLmNvbS5jbXNF",
            "bmdpbmUuZ3JwYy5JZGVudBoZLmNvbS5jbXNFbmdpbmUuZ3JwYy5FbG1udDAB",
            "MrMDCgxBZG1pblNlcnZpY2USQgoGY3JlYXRlEhsuY29tLmNtc0VuZ2luZS5n",
            "cnBjLlJwY1ZvaWQaGy5jb20uY21zRW5naW5lLmdycGMuUnBjVm9pZBJACgRk",
            "cm9wEhsuY29tLmNtc0VuZ2luZS5ncnBjLlJwY1ZvaWQaGy5jb20uY21zRW5n",
            "aW5lLmdycGMuUnBjVm9pZBJNChFpbnNlcnREZWZhdWx0RGF0YRIbLmNvbS5j",
            "bXNFbmdpbmUuZ3JwYy5ScGNWb2lkGhsuY29tLmNtc0VuZ2luZS5ncnBjLlJw",
            "Y1ZvaWQSQgoGYmFja3VwEhsuY29tLmNtc0VuZ2luZS5ncnBjLlJwY1ZvaWQa",
            "Gy5jb20uY21zRW5naW5lLmdycGMuUnBjVm9pZBJBCgdnZXRMb2dzEhsuY29t",
            "LmNtc0VuZ2luZS5ncnBjLlJwY1ZvaWQaGS5jb20uY21zRW5naW5lLmdycGMu",
            "RWxtbnQSRwoNZ2V0U3RhdGlzdGljcxIbLmNvbS5jbXNFbmdpbmUuZ3JwYy5S",
            "cGNWb2lkGhkuY29tLmNtc0VuZ2luZS5ncnBjLkVsbW50YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.CmsEngine.Grpc.Ident), global::Com.CmsEngine.Grpc.Ident.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.CmsEngine.Grpc.Param), global::Com.CmsEngine.Grpc.Param.Parser, new[]{ "MKey", "MValues" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.CmsEngine.Grpc.Elmnt), global::Com.CmsEngine.Grpc.Elmnt.Parser, new[]{ "Id", "P" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.CmsEngine.Grpc.ElmntList), global::Com.CmsEngine.Grpc.ElmntList.Parser, new[]{ "Elmnts" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.CmsEngine.Grpc.RpcVoid), global::Com.CmsEngine.Grpc.RpcVoid.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Ident : pb::IMessage<Ident> {
    private static readonly pb::MessageParser<Ident> _parser = new pb::MessageParser<Ident>(() => new Ident());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Ident> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.CmsEngine.Grpc.CmsEngineReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ident() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ident(Ident other) : this() {
      id_ = other.id_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Ident Clone() {
      return new Ident(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Ident);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Ident other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Ident other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Param : pb::IMessage<Param> {
    private static readonly pb::MessageParser<Param> _parser = new pb::MessageParser<Param>(() => new Param());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Param> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.CmsEngine.Grpc.CmsEngineReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Param() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Param(Param other) : this() {
      mKey_ = other.mKey_;
      mValues_ = other.mValues_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Param Clone() {
      return new Param(this);
    }

    /// <summary>Field number for the "mKey" field.</summary>
    public const int MKeyFieldNumber = 1;
    private string mKey_ = "";
    /// <summary>
    ///  string mValue = 2; // depr
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MKey {
      get { return mKey_; }
      set {
        mKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mValues" field.</summary>
    public const int MValuesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_mValues_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> mValues_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> MValues {
      get { return mValues_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Param);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Param other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MKey != other.MKey) return false;
      if(!mValues_.Equals(other.mValues_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MKey.Length != 0) hash ^= MKey.GetHashCode();
      hash ^= mValues_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MKey);
      }
      mValues_.WriteTo(output, _repeated_mValues_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MKey);
      }
      size += mValues_.CalculateSize(_repeated_mValues_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Param other) {
      if (other == null) {
        return;
      }
      if (other.MKey.Length != 0) {
        MKey = other.MKey;
      }
      mValues_.Add(other.mValues_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            MKey = input.ReadString();
            break;
          }
          case 26: {
            mValues_.AddEntriesFrom(input, _repeated_mValues_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Elmnt : pb::IMessage<Elmnt> {
    private static readonly pb::MessageParser<Elmnt> _parser = new pb::MessageParser<Elmnt>(() => new Elmnt());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Elmnt> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.CmsEngine.Grpc.CmsEngineReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Elmnt() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Elmnt(Elmnt other) : this() {
      id_ = other.id_;
      p_ = other.p_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Elmnt Clone() {
      return new Elmnt(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "p" field.</summary>
    public const int PFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Com.CmsEngine.Grpc.Param> _repeated_p_codec
        = pb::FieldCodec.ForMessage(18, global::Com.CmsEngine.Grpc.Param.Parser);
    private readonly pbc::RepeatedField<global::Com.CmsEngine.Grpc.Param> p_ = new pbc::RepeatedField<global::Com.CmsEngine.Grpc.Param>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.CmsEngine.Grpc.Param> P {
      get { return p_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Elmnt);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Elmnt other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!p_.Equals(other.p_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= p_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      p_.WriteTo(output, _repeated_p_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      size += p_.CalculateSize(_repeated_p_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Elmnt other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      p_.Add(other.p_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            p_.AddEntriesFrom(input, _repeated_p_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ElmntList : pb::IMessage<ElmntList> {
    private static readonly pb::MessageParser<ElmntList> _parser = new pb::MessageParser<ElmntList>(() => new ElmntList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ElmntList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.CmsEngine.Grpc.CmsEngineReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ElmntList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ElmntList(ElmntList other) : this() {
      elmnts_ = other.elmnts_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ElmntList Clone() {
      return new ElmntList(this);
    }

    /// <summary>Field number for the "elmnts" field.</summary>
    public const int ElmntsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Com.CmsEngine.Grpc.Elmnt> _repeated_elmnts_codec
        = pb::FieldCodec.ForMessage(10, global::Com.CmsEngine.Grpc.Elmnt.Parser);
    private readonly pbc::RepeatedField<global::Com.CmsEngine.Grpc.Elmnt> elmnts_ = new pbc::RepeatedField<global::Com.CmsEngine.Grpc.Elmnt>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.CmsEngine.Grpc.Elmnt> Elmnts {
      get { return elmnts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ElmntList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ElmntList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!elmnts_.Equals(other.elmnts_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= elmnts_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      elmnts_.WriteTo(output, _repeated_elmnts_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += elmnts_.CalculateSize(_repeated_elmnts_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ElmntList other) {
      if (other == null) {
        return;
      }
      elmnts_.Add(other.elmnts_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            elmnts_.AddEntriesFrom(input, _repeated_elmnts_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RpcVoid : pb::IMessage<RpcVoid> {
    private static readonly pb::MessageParser<RpcVoid> _parser = new pb::MessageParser<RpcVoid>(() => new RpcVoid());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RpcVoid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.CmsEngine.Grpc.CmsEngineReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RpcVoid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RpcVoid(RpcVoid other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RpcVoid Clone() {
      return new RpcVoid(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RpcVoid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RpcVoid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RpcVoid other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
