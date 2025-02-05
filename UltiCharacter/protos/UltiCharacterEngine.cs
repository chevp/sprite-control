// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ultiCharacterEngine.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Com.UltiCharacter.Grpc {

  /// <summary>Holder for reflection information generated from ultiCharacterEngine.proto</summary>
  public static partial class UltiCharacterEngineReflection {

    #region Descriptor
    /// <summary>File descriptor for ultiCharacterEngine.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UltiCharacterEngineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chl1bHRpQ2hhcmFjdGVyRW5naW5lLnByb3RvEhZjb20udWx0aUNoYXJhY3Rl",
            "ci5ncnBjGg1jb21tb24yLnByb3RvIjoKC0luaXRNZXNzYWdlEgoKAmlkGAEg",
            "ASgHEg8KB3RpbWVGYWMYAiABKAISDgoGZ2x0ZklkGAMgASgHIrEBCgtTeXN0",
            "ZW1Nb2RlbBIKCgJpZBgBIAEoBxIsCgVzdGF0ZRgCIAEoDjIdLmNvbS51bHRp",
            "Q2hhcmFjdGVyLmdycGMuU3RhdGUSEwoDcG9zGAMgASgLMgYuRlZlYzMSEwoD",
            "dmVsGAQgASgLMgYuRlZlYzMSEQoJYW5pbWF0aW9uGAUgASgNEhYKDmFuaW1h",
            "dGlvblRpbWVyGAYgASgCEhMKA2RpchgHIAEoCzIGLkZWZWMzIkYKD1N5c3Rl",
            "bU1vZGVsTGlzdBIzCgZtb2RlbHMYASADKAsyIy5jb20udWx0aUNoYXJhY3Rl",
            "ci5ncnBjLlN5c3RlbU1vZGVsKl4KBVN0YXRlEhUKEVNUQVRFX1VOU1BFQ0lG",
            "SUVEEAASDwoLU1RBVEVfUkVBRFkQARIOCgpTVEFURV9JRExFEAISDgoKU1RB",
            "VEVfV0FMSxADEg0KCVNUQVRFX1JVThAEKmkKB1RyaWdnZXISFwoTVFJJR0dF",
            "Ul9VTlNQRUNJRklFRBAAEhAKDFRSSUdHRVJfU1RPUBABEg8KC1RSSUdHRVJf",
            "UlVOEAISEAoMVFJJR0dFUl9XQUxLEAMSEAoMVFJJR0dFUl9JTklUEAQymwMK",
            "GlVsdGlDaGFyYWN0ZXJFbmdpbmVTZXJ2aWNlEhoKBHBpbmcSCC5ScGNWb2lk",
            "GgguUnBjVm9pZBI1CgRpbml0EiMuY29tLnVsdGlDaGFyYWN0ZXIuZ3JwYy5J",
            "bml0TWVzc2FnZRoILlJwY1ZvaWQSGgoGcmVtb3ZlEgYuSWRlbnQaCC5ScGNW",
            "b2lkEhgKBGlkbGUSBi5JZGVudBoILlJwY1ZvaWQSFwoDcnVuEgYuSWRlbnQa",
            "CC5ScGNWb2lkEhgKBHdhbGsSBi5JZGVudBoILlJwY1ZvaWQSOwoGZ2V0QWxs",
            "EgguUnBjVm9pZBonLmNvbS51bHRpQ2hhcmFjdGVyLmdycGMuU3lzdGVtTW9k",
            "ZWxMaXN0Ej0KDmdldFN5c3RlbU1vZGVsEgYuSWRlbnQaIy5jb20udWx0aUNo",
            "YXJhY3Rlci5ncnBjLlN5c3RlbU1vZGVsEkUKFHN1YnNjcmliZVN5c3RlbU1v",
            "ZGVsEgYuSWRlbnQaIy5jb20udWx0aUNoYXJhY3Rlci5ncnBjLlN5c3RlbU1v",
            "ZGVsMAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common2Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Com.UltiCharacter.Grpc.State), typeof(global::Com.UltiCharacter.Grpc.Trigger), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.UltiCharacter.Grpc.InitMessage), global::Com.UltiCharacter.Grpc.InitMessage.Parser, new[]{ "Id", "TimeFac", "GltfId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.UltiCharacter.Grpc.SystemModel), global::Com.UltiCharacter.Grpc.SystemModel.Parser, new[]{ "Id", "State", "Pos", "Vel", "Animation", "AnimationTimer", "Dir" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Com.UltiCharacter.Grpc.SystemModelList), global::Com.UltiCharacter.Grpc.SystemModelList.Parser, new[]{ "Models" }, null, null, null)
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
  public sealed partial class InitMessage : pb::IMessage<InitMessage> {
    private static readonly pb::MessageParser<InitMessage> _parser = new pb::MessageParser<InitMessage>(() => new InitMessage());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Com.UltiCharacter.Grpc.UltiCharacterEngineReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitMessage(InitMessage other) : this() {
      id_ = other.id_;
      timeFac_ = other.timeFac_;
      gltfId_ = other.gltfId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitMessage Clone() {
      return new InitMessage(this);
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
      return Equals(other as InitMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitMessage other) {
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
    public void MergeFrom(InitMessage other) {
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
      get { return global::Com.UltiCharacter.Grpc.UltiCharacterEngineReflection.Descriptor.MessageTypes[1]; }
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
    private global::Com.UltiCharacter.Grpc.State state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Com.UltiCharacter.Grpc.State State {
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
            state_ = (global::Com.UltiCharacter.Grpc.State) input.ReadEnum();
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
      get { return global::Com.UltiCharacter.Grpc.UltiCharacterEngineReflection.Descriptor.MessageTypes[2]; }
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
    private static readonly pb::FieldCodec<global::Com.UltiCharacter.Grpc.SystemModel> _repeated_models_codec
        = pb::FieldCodec.ForMessage(10, global::Com.UltiCharacter.Grpc.SystemModel.Parser);
    private readonly pbc::RepeatedField<global::Com.UltiCharacter.Grpc.SystemModel> models_ = new pbc::RepeatedField<global::Com.UltiCharacter.Grpc.SystemModel>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Com.UltiCharacter.Grpc.SystemModel> Models {
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
