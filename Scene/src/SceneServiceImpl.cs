
using Grpc.Core;
using System;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Com.Scene.Grpc;
using Com.Island.Grpc;
using System.Collections.Generic;

namespace Scene
{
    public class SceneServiceImpl : SceneEngineService.SceneEngineServiceBase
    {
        // private NameValueCollection config;
        private SceneService _scene = new SceneService();
        // const string host = "localhost";
        //private static int portIsland = 67589;

        //private static IslandEngineService.IslandEngineServiceClient _island;
        //private static Channel channelIsland;

        //private static HashSet<IServerStreamWriter<Elmnt>> responseStreamsElmnt =
        //    new HashSet<IServerStreamWriter<ViewPortElmnts>>();
        public SceneServiceImpl()
        {
            // config = ConfigUtil.readConfig();

            //channelIsland = new Channel($"{host}:{portIsland}", ChannelCredentials.Insecure);
            //_island = new IslandEngineService.IslandEngineServiceClient(channelIsland);
        }
        public override Task<RpcVoid> ping(RpcVoid request, ServerCallContext context)
        {
            return Task.FromResult(new RpcVoid());
        }

        public override Task<RpcVoid> init(InitScene request, ServerCallContext context)
        {
            Console.WriteLine($"SceneServiceImpl.init id={request.Id}");
            try
            {
                _scene.init(request);
            }
            catch (Exception e)
            {
                throw new RpcException(new Status(StatusCode.Internal, e.Message));
            }
            return Task.FromResult(new RpcVoid());
        }

        public override Task<RpcVoid> restart(Ident request, ServerCallContext context)
        {
            Console.WriteLine($"SceneServiceImpl.restart id={request.Id}");
            try
            {
                _scene.restart(request.Id);
            }
            catch (Exception e)
            {
                throw new RpcException(new Status(StatusCode.Internal, e.Message));
            }
            return Task.FromResult(new RpcVoid());
        }
    }
}