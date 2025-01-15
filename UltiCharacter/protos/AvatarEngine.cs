// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: avatarEngine.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.Avatar.Grpc {

  /// <summary>Holder for reflection information generated from avatarEngine.proto</summary>
  public static partial class AvatarEngineReflection {

    #region Descriptor
    /// <summary>File descriptor for avatarEngine.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarEngineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJhdmF0YXJFbmdpbmUucHJvdG8SD2NvbS5hdmF0YXIuZ3JwYxoNY29tbW9u",
            "Mi5wcm90byI5CgpJbml0QXZhdGFyEgoKAmlkGAEgASgHEg8KB3RpbWVGYWMY",
            "AiABKAISDgoGZ2x0ZklkGAMgASgHIqoBCgtTeXN0ZW1Nb2RlbBIKCgJpZBgB",
            "IAEoBxIlCgVzdGF0ZRgCIAEoDjIWLmNvbS5hdmF0YXIuZ3JwYy5TdGF0ZRIT",
            "CgNwb3MYAyABKAsyBi5GVmVjMxITCgN2ZWwYBCABKAsyBi5GVmVjMxIRCglh",
            "bmltYXRpb24YBSABKA0SFgoOYW5pbWF0aW9uVGltZXIYBiABKAISEwoDZGly",
            "GAcgASgLMgYuRlZlYzMiPwoPU3lzdGVtTW9kZWxMaXN0EiwKBm1vZGVscxgB",
            "IAMoCzIcLmNvbS5hdmF0YXIuZ3JwYy5TeXN0ZW1Nb2RlbCpeCgVTdGF0ZRIV",
            "ChFTVEFURV9VTlNQRUNJRklFRBAAEg8KC1NUQVRFX1JFQURZEAESDgoKU1RB",
            "VEVfSURMRRACEg4KClNUQVRFX1dBTEsQAxINCglTVEFURV9SVU4QBCppCgdU",
            "cmlnZ2VyEhcKE1RSSUdHRVJfVU5TUEVDSUZJRUQQABIQCgxUUklHR0VSX1NU",
            "T1AQARIPCgtUUklHR0VSX1JVThACEhAKDFRSSUdHRVJfV0FMSxADEhAKDFRS",
            "SUdHRVJfSU5JVBAEMvcCChNBdmF0YXJFbmdpbmVTZXJ2aWNlEhoKBHBpbmcS",
            "CC5ScGNWb2lkGgguUnBjVm9pZBItCgRpbml0EhsuY29tLmF2YXRhci5ncnBj",
            "LkluaXRBdmF0YXIaCC5ScGNWb2lkEhoKBnJlbW92ZRIGLklkZW50GgguUnBj",
            "Vm9pZBIYCgRpZGxlEgYuSWRlbnQaCC5ScGNWb2lkEhcKA3J1bhIGLklkZW50",
            "GgguUnBjVm9pZBIYCgR3YWxrEgYuSWRlbnQaCC5ScGNWb2lkEjQKBmdldEFs",
            "bBIILlJwY1ZvaWQaIC5jb20uYXZhdGFyLmdycGMuU3lzdGVtTW9kZWxMaXN0",
            "EjYKDmdldFN5c3RlbU1vZGVsEgYuSWRlbnQaHC5jb20uYXZhdGFyLmdycGMu",
            "U3lzdGVtTW9kZWwSPgoUc3Vic2NyaWJlU3lzdGVtTW9kZWwSBi5JZGVudBoc",
            "LmNvbS5hdmF0YXIuZ3JwYy5TeXN0ZW1Nb2RlbDABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common2Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Com.Avatar.Grpc.State), typeof(global::Com.Avatar.Grpc.Trigger), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Avatar.Grpc.InitAvatar), global::Com.Avatar.Grpc.InitAvatar.Parser, new[]{ "Id", "TimeFac", "GltfId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Avatar.Grpc.SystemModel), global::Com.Avatar.Grpc.SystemModel.Parser, new[]{ "Id", "State", "Pos", "Vel", "Animation", "AnimationTimer", "Dir" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.Avatar.Grpc.SystemModelList), global::Com.Avatar.Grpc.SystemModelList.Parser, new[]{ "Models" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum State {
    [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("STATE_READY")] Ready = 1,
    [pbr::OriginalName("STATE_IDLE")] Idle = 2,
    [pbr::OriginalName("STATE_WALK")] Walk = 3,
    [pbr::OriginalName("STATE_RUN")] Run = 4,
  }

  public enum Trigger {
    [pbr::OriginalName("TRIGGER_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("TRIGGER_STOP")] Stop = 1,
    [pbr::OriginalName("TRIGGER_RUN")] Run = 2,
    [pbr::OriginalName("TRIGGER_WALK")] Walk = 3,
    [pbr::OriginalName("TRIGGER_INIT")] Init = 4,
  }

  #endregion

  #region Messages
  public sealed partial class InitAvatar : pb::IMessage<InitAvatar> {
    private static readonly pb::MessageParser<InitAvatar> _parser = new pb::MessageParser<InitAvatar>(() => new InitAvatar());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitAvatar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Avatar.Grpc.AvatarEngineReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitAvatar(InitAvatar other) : this() {
      id_ = other.id_;
      timeFac_ = other.timeFac_;
      gltfId_ = other.gltfId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitAvatar Clone() {
      return new InitAvatar(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "timeFac" field.</summary>
    public const int TimeFacFieldNumber = 2;
    private float timeFac_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TimeFac {
      get { return timeFac_; }
      set {
        timeFac_ = value;
      }
    }

    /// <summary>Field number for the "gltfId" field.</summary>
    public const int GltfIdFieldNumber = 3;
    private uint gltfId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint GltfId {
      get { return gltfId_; }
      set {
        gltfId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitAvatar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (TimeFac != other.TimeFac) return false;
      if (GltfId != other.GltfId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (TimeFac != 0F) hash ^= TimeFac.GetHashCode();
      if (GltfId != 0) hash ^= GltfId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(13);
        output.WriteFixed32(Id);
      }
      if (TimeFac != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(TimeFac);
      }
      if (GltfId != 0) {
        output.WriteRawTag(29);
        output.WriteFixed32(GltfId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + 4;
      }
      if (TimeFac != 0F) {
        size += 1 + 4;
      }
      if (GltfId != 0) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitAvatar other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.TimeFac != 0F) {
        TimeFac = other.TimeFac;
      }
      if (other.GltfId != 0) {
        GltfId = other.GltfId;
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
          case 13: {
            Id = input.ReadFixed32();
            break;
          }
          case 21: {
            TimeFac = input.ReadFloat();
            break;
          }
          case 29: {
            GltfId = input.ReadFixed32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class SystemModel : pb::IMessage<SystemModel> {
    private static readonly pb::MessageParser<SystemModel> _parser = new pb::MessageParser<SystemModel>(() => new SystemModel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Avatar.Grpc.AvatarEngineReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemModel(SystemModel other) : this() {
      id_ = other.id_;
      state_ = other.state_;
      Pos = other.pos_ != null ? other.Pos.Clone() : null;
      Vel = other.vel_ != null ? other.Vel.Clone() : null;
      animation_ = other.animation_;
      animationTimer_ = other.animationTimer_;
      Dir = other.dir_ != null ? other.Dir.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemModel Clone() {
      return new SystemModel(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::Com.Avatar.Grpc.State state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.Avatar.Grpc.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 3;
    private global::FVec3 pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FVec3 Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "vel" field.</summary>
    public const int VelFieldNumber = 4;
    private global::FVec3 vel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FVec3 Vel {
      get { return vel_; }
      set {
        vel_ = value;
      }
    }

    /// <summary>Field number for the "animation" field.</summary>
    public const int AnimationFieldNumber = 5;
    private uint animation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Animation {
      get { return animation_; }
      set {
        animation_ = value;
      }
    }

    /// <summary>Field number for the "animationTimer" field.</summary>
    public const int AnimationTimerFieldNumber = 6;
    private float animationTimer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float AnimationTimer {
      get { return animationTimer_; }
      set {
        animationTimer_ = value;
      }
    }

    /// <summary>Field number for the "dir" field.</summary>
    public const int DirFieldNumber = 7;
    private global::FVec3 dir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::FVec3 Dir {
      get { return dir_; }
      set {
        dir_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (State != other.State) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Vel, other.Vel)) return false;
      if (Animation != other.Animation) return false;
      if (AnimationTimer != other.AnimationTimer) return false;
      if (!object.Equals(Dir, other.Dir)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (vel_ != null) hash ^= Vel.GetHashCode();
      if (Animation != 0) hash ^= Animation.GetHashCode();
      if (AnimationTimer != 0F) hash ^= AnimationTimer.GetHashCode();
      if (dir_ != null) hash ^= Dir.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(13);
        output.WriteFixed32(Id);
      }
      if (State != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (pos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Pos);
      }
      if (vel_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Vel);
      }
      if (Animation != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Animation);
      }
      if (AnimationTimer != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(AnimationTimer);
      }
      if (dir_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Dir);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + 4;
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (vel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Vel);
      }
      if (Animation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Animation);
      }
      if (AnimationTimer != 0F) {
        size += 1 + 4;
      }
      if (dir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Dir);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemModel other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          pos_ = new global::FVec3();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.vel_ != null) {
        if (vel_ == null) {
          vel_ = new global::FVec3();
        }
        Vel.MergeFrom(other.Vel);
      }
      if (other.Animation != 0) {
        Animation = other.Animation;
      }
      if (other.AnimationTimer != 0F) {
        AnimationTimer = other.AnimationTimer;
      }
      if (other.dir_ != null) {
        if (dir_ == null) {
          dir_ = new global::FVec3();
        }
        Dir.MergeFrom(other.Dir);
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
          case 13: {
            Id = input.ReadFixed32();
            break;
          }
          case 16: {
            state_ = (global::Com.Avatar.Grpc.State) input.ReadEnum();
            break;
          }
          case 26: {
            if (pos_ == null) {
              pos_ = new global::FVec3();
            }
            input.ReadMessage(pos_);
            break;
          }
          case 34: {
            if (vel_ == null) {
              vel_ = new global::FVec3();
            }
            input.ReadMessage(vel_);
            break;
          }
          case 40: {
            Animation = input.ReadUInt32();
            break;
          }
          case 53: {
            AnimationTimer = input.ReadFloat();
            break;
          }
          case 58: {
            if (dir_ == null) {
              dir_ = new global::FVec3();
            }
            input.ReadMessage(dir_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SystemModelList : pb::IMessage<SystemModelList> {
    private static readonly pb::MessageParser<SystemModelList> _parser = new pb::MessageParser<SystemModelList>(() => new SystemModelList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SystemModelList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.Avatar.Grpc.AvatarEngineReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemModelList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemModelList(SystemModelList other) : this() {
      models_ = other.models_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SystemModelList Clone() {
      return new SystemModelList(this);
    }

    /// <summary>Field number for the "models" field.</summary>
    public const int ModelsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Com.Avatar.Grpc.SystemModel> _repeated_models_codec
        = pb::FieldCodec.ForMessage(10, global::Com.Avatar.Grpc.SystemModel.Parser);
    private readonly pbc::RepeatedField<global::Com.Avatar.Grpc.SystemModel> models_ = new pbc::RepeatedField<global::Com.Avatar.Grpc.SystemModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.Avatar.Grpc.SystemModel> Models {
      get { return models_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SystemModelList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SystemModelList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!models_.Equals(other.models_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= models_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      models_.WriteTo(output, _repeated_models_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += models_.CalculateSize(_repeated_models_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SystemModelList other) {
      if (other == null) {
        return;
      }
      models_.Add(other.models_);
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
            models_.AddEntriesFrom(input, _repeated_models_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
