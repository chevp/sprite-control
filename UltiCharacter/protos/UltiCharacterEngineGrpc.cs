// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ultiCharacterEngine.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Com.UltiCharacter.Grpc {
  public static class UltiCharacterEngineService
  {
    static readonly string __ServiceName = "com.ultiCharacter.grpc.UltiCharacterEngineService";

    static readonly Marshaller<global::RpcVoid> __Marshaller_RpcVoid = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RpcVoid.Parser.ParseFrom);
    static readonly Marshaller<global::Com.UltiCharacter.Grpc.InitMessage> __Marshaller_InitMessage = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.UltiCharacter.Grpc.InitMessage.Parser.ParseFrom);
    static readonly Marshaller<global::Ident> __Marshaller_Ident = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Ident.Parser.ParseFrom);
    static readonly Marshaller<global::Com.UltiCharacter.Grpc.SystemModelList> __Marshaller_SystemModelList = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.UltiCharacter.Grpc.SystemModelList.Parser.ParseFrom);
    static readonly Marshaller<global::Com.UltiCharacter.Grpc.SystemModel> __Marshaller_SystemModel = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Com.UltiCharacter.Grpc.SystemModel.Parser.ParseFrom);

    static readonly Method<global::RpcVoid, global::RpcVoid> __Method_ping = new Method<global::RpcVoid, global::RpcVoid>(
        MethodType.Unary,
        __ServiceName,
        "ping",
        __Marshaller_RpcVoid,
        __Marshaller_RpcVoid);

    static readonly Method<global::Com.UltiCharacter.Grpc.InitMessage, global::RpcVoid> __Method_init = new Method<global::Com.UltiCharacter.Grpc.InitMessage, global::RpcVoid>(
        MethodType.Unary,
        __ServiceName,
        "init",
        __Marshaller_InitMessage,
        __Marshaller_RpcVoid);

    static readonly Method<global::Ident, global::RpcVoid> __Method_remove = new Method<global::Ident, global::RpcVoid>(
        MethodType.Unary,
        __ServiceName,
        "remove",
        __Marshaller_Ident,
        __Marshaller_RpcVoid);

    static readonly Method<global::Ident, global::RpcVoid> __Method_idle = new Method<global::Ident, global::RpcVoid>(
        MethodType.Unary,
        __ServiceName,
        "idle",
        __Marshaller_Ident,
        __Marshaller_RpcVoid);

    static readonly Method<global::Ident, global::RpcVoid> __Method_run = new Method<global::Ident, global::RpcVoid>(
        MethodType.Unary,
        __ServiceName,
        "run",
        __Marshaller_Ident,
        __Marshaller_RpcVoid);

    static readonly Method<global::Ident, global::RpcVoid> __Method_walk = new Method<global::Ident, global::RpcVoid>(
        MethodType.Unary,
        __ServiceName,
        "walk",
        __Marshaller_Ident,
        __Marshaller_RpcVoid);

    static readonly Method<global::RpcVoid, global::Com.UltiCharacter.Grpc.SystemModelList> __Method_getAll = new Method<global::RpcVoid, global::Com.UltiCharacter.Grpc.SystemModelList>(
        MethodType.Unary,
        __ServiceName,
        "getAll",
        __Marshaller_RpcVoid,
        __Marshaller_SystemModelList);

    static readonly Method<global::Ident, global::Com.UltiCharacter.Grpc.SystemModel> __Method_getSystemModel = new Method<global::Ident, global::Com.UltiCharacter.Grpc.SystemModel>(
        MethodType.Unary,
        __ServiceName,
        "getSystemModel",
        __Marshaller_Ident,
        __Marshaller_SystemModel);

    static readonly Method<global::Ident, global::Com.UltiCharacter.Grpc.SystemModel> __Method_subscribeSystemModel = new Method<global::Ident, global::Com.UltiCharacter.Grpc.SystemModel>(
        MethodType.ServerStreaming,
        __ServiceName,
        "subscribeSystemModel",
        __Marshaller_Ident,
        __Marshaller_SystemModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Com.UltiCharacter.Grpc.UltiCharacterEngineReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of UltiCharacterEngineService</summary>
    public abstract class UltiCharacterEngineServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::RpcVoid> ping(global::RpcVoid request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  adds also new statemachine
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::RpcVoid> init(global::Com.UltiCharacter.Grpc.InitMessage request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RpcVoid> remove(global::Ident request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RpcVoid> idle(global::Ident request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RpcVoid> run(global::Ident request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RpcVoid> walk(global::Ident request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Com.UltiCharacter.Grpc.SystemModelList> getAll(global::RpcVoid request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Com.UltiCharacter.Grpc.SystemModel> getSystemModel(global::Ident request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task subscribeSystemModel(global::Ident request, IServerStreamWriter<global::Com.UltiCharacter.Grpc.SystemModel> responseStream, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for UltiCharacterEngineService</summary>
    public class UltiCharacterEngineServiceClient : ClientBase<UltiCharacterEngineServiceClient>
    {
      /// <summary>Creates a new client for UltiCharacterEngineService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UltiCharacterEngineServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UltiCharacterEngineService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UltiCharacterEngineServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UltiCharacterEngineServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UltiCharacterEngineServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::RpcVoid ping(global::RpcVoid request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ping(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RpcVoid ping(global::RpcVoid request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ping, null, options, request);
      }
      public virtual AsyncUnaryCall<global::RpcVoid> pingAsync(global::RpcVoid request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return pingAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::RpcVoid> pingAsync(global::RpcVoid request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ping, null, options, request);
      }
      /// <summary>
      ///  adds also new statemachine
      /// </summary>
      public virtual global::RpcVoid init(global::Com.UltiCharacter.Grpc.InitMessage request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return init(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  adds also new statemachine
      /// </summary>
      public virtual global::RpcVoid init(global::Com.UltiCharacter.Grpc.InitMessage request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_init, null, options, request);
      }
      /// <summary>
      ///  adds also new statemachine
      /// </summary>
      public virtual AsyncUnaryCall<global::RpcVoid> initAsync(global::Com.UltiCharacter.Grpc.InitMessage request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return initAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  adds also new statemachine
      /// </summary>
      public virtual AsyncUnaryCall<global::RpcVoid> initAsync(global::Com.UltiCharacter.Grpc.InitMessage request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_init, null, options, request);
      }
      public virtual global::RpcVoid remove(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return remove(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RpcVoid remove(global::Ident request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_remove, null, options, request);
      }
      public virtual AsyncUnaryCall<global::RpcVoid> removeAsync(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return removeAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::RpcVoid> removeAsync(global::Ident request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_remove, null, options, request);
      }
      public virtual global::RpcVoid idle(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return idle(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RpcVoid idle(global::Ident request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_idle, null, options, request);
      }
      public virtual AsyncUnaryCall<global::RpcVoid> idleAsync(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return idleAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::RpcVoid> idleAsync(global::Ident request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_idle, null, options, request);
      }
      public virtual global::RpcVoid run(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return run(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RpcVoid run(global::Ident request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_run, null, options, request);
      }
      public virtual AsyncUnaryCall<global::RpcVoid> runAsync(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return runAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::RpcVoid> runAsync(global::Ident request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_run, null, options, request);
      }
      public virtual global::RpcVoid walk(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return walk(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RpcVoid walk(global::Ident request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_walk, null, options, request);
      }
      public virtual AsyncUnaryCall<global::RpcVoid> walkAsync(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return walkAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::RpcVoid> walkAsync(global::Ident request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_walk, null, options, request);
      }
      public virtual global::Com.UltiCharacter.Grpc.SystemModelList getAll(global::RpcVoid request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getAll(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.UltiCharacter.Grpc.SystemModelList getAll(global::RpcVoid request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getAll, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Com.UltiCharacter.Grpc.SystemModelList> getAllAsync(global::RpcVoid request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getAllAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Com.UltiCharacter.Grpc.SystemModelList> getAllAsync(global::RpcVoid request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getAll, null, options, request);
      }
      public virtual global::Com.UltiCharacter.Grpc.SystemModel getSystemModel(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getSystemModel(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Com.UltiCharacter.Grpc.SystemModel getSystemModel(global::Ident request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_getSystemModel, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Com.UltiCharacter.Grpc.SystemModel> getSystemModelAsync(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return getSystemModelAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Com.UltiCharacter.Grpc.SystemModel> getSystemModelAsync(global::Ident request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_getSystemModel, null, options, request);
      }
      public virtual AsyncServerStreamingCall<global::Com.UltiCharacter.Grpc.SystemModel> subscribeSystemModel(global::Ident request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return subscribeSystemModel(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncServerStreamingCall<global::Com.UltiCharacter.Grpc.SystemModel> subscribeSystemModel(global::Ident request, CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_subscribeSystemModel, null, options, request);
      }
      protected override UltiCharacterEngineServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UltiCharacterEngineServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(UltiCharacterEngineServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ping, serviceImpl.ping)
          .AddMethod(__Method_init, serviceImpl.init)
          .AddMethod(__Method_remove, serviceImpl.remove)
          .AddMethod(__Method_idle, serviceImpl.idle)
          .AddMethod(__Method_run, serviceImpl.run)
          .AddMethod(__Method_walk, serviceImpl.walk)
          .AddMethod(__Method_getAll, serviceImpl.getAll)
          .AddMethod(__Method_getSystemModel, serviceImpl.getSystemModel)
          .AddMethod(__Method_subscribeSystemModel, serviceImpl.subscribeSystemModel).Build();
    }

  }
}
#endregion
