// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: helloworld.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace GRPCDemo {
  public static class gRPC
  {
    static readonly string __ServiceName = "gRPCDemo.gRPC";

    static readonly Marshaller<global::GRPCDemo.HelloRequest> __Marshaller_HelloRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPCDemo.HelloRequest.Parser.ParseFrom);
    static readonly Marshaller<global::GRPCDemo.HelloReply> __Marshaller_HelloReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GRPCDemo.HelloReply.Parser.ParseFrom);

    static readonly Method<global::GRPCDemo.HelloRequest, global::GRPCDemo.HelloReply> __Method_SayHello = new Method<global::GRPCDemo.HelloRequest, global::GRPCDemo.HelloReply>(
        MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_HelloRequest,
        __Marshaller_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPCDemo.HelloworldReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of gRPC</summary>
    public abstract class gRPCBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GRPCDemo.HelloReply> SayHello(global::GRPCDemo.HelloRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for gRPC</summary>
    public class gRPCClient : ClientBase<gRPCClient>
    {
      /// <summary>Creates a new client for gRPC</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public gRPCClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for gRPC that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public gRPCClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected gRPCClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected gRPCClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GRPCDemo.HelloReply SayHello(global::GRPCDemo.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SayHello(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GRPCDemo.HelloReply SayHello(global::GRPCDemo.HelloRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual AsyncUnaryCall<global::GRPCDemo.HelloReply> SayHelloAsync(global::GRPCDemo.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SayHelloAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::GRPCDemo.HelloReply> SayHelloAsync(global::GRPCDemo.HelloRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      protected override gRPCClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new gRPCClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(gRPCBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

  }
}
#endregion
