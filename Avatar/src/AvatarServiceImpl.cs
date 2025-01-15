
using Grpc.Core;
using System;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Com.Ipcoe1.Grpc;

namespace AvatarApi
{
    public class AvatarServiceImpl : IPCOE1Service.IPCOE1ServiceBase
    {
        private NameValueCollection config;
        private AvatarService _ultiCharacter = new AvatarService();
        // const string host = "localhost";
        // private static int portIsland = 67589;

        //private static IslandEngineService.IslandEngineServiceClient _island;
        // private static Channel channelIsland;

        //private static HashSet<IServerStreamWriter<Elmnt>> responseStreamsElmnt =
        //    new HashSet<IServerStreamWriter<Elmnt>>();

        public AvatarServiceImpl()
        {
            // config = ConfigUtil.readConfig();

            // channelIsland = new Channel($"{host}:{portIsland}", ChannelCredentials.Insecure);
            // _island = new IslandEngineService.IslandEngineServiceClient(channelIsland);
        }
        public override Task<RpcVoid> ping(RpcVoid request, ServerCallContext context)
        {
            return Task.FromResult(new RpcVoid());
        }
        public override Task<Value> get(Value request, ServerCallContext context)
        {
            Console.WriteLine($"UltiCharacterServiceImpl.get");
            try
            {
                if (request.KindCase == Value.KindOneofCase.StructValue)
                {
                    request.StructValue.Value.TryGetValue("cmd", out Value cmd);

                    return Task.FromResult(_ultiCharacter.sendEvent(cmd.DictionaryValue, request));                
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"UltiCharacterServiceImpl.get: Exception={e.Message}");

                throw new RpcException(new Status(StatusCode.Internal, e.Message));
            }
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }

        public override Task<RpcVoid> post(Value request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }

        public override Task<RpcVoid> put(Value request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }

        public override Task<RpcVoid> remove(Value request, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }

        public override Task subscribe(global::Com.Ipcoe1.Grpc.Struct request, IServerStreamWriter<global::Com.Ipcoe1.Grpc.Value> responseStream, ServerCallContext context)
        {
            throw new RpcException(new Status(StatusCode.Unimplemented, ""));
        }
    }
}