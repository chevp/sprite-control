
using Grpc.Core;
using System;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Com.UltiCharacter.Grpc;

namespace UltiCharacter
{
    public class UltiCharacterServiceImpl : UltiCharacterEngineService.UltiCharacterEngineServiceBase
    {
        private NameValueCollection config;
        private UltiCharacterService _ultiCharacter = new UltiCharacterService();
        // const string host = "localhost";
        // private static int portIsland = 67589;

        //private static IslandEngineService.IslandEngineServiceClient _island;
        // private static Channel channelIsland;

        //private static HashSet<IServerStreamWriter<Elmnt>> responseStreamsElmnt =
        //    new HashSet<IServerStreamWriter<Elmnt>>();
        public UltiCharacterServiceImpl()
        {
            // config = ConfigUtil.readConfig();

            // channelIsland = new Channel($"{host}:{portIsland}", ChannelCredentials.Insecure);
            // _island = new IslandEngineService.IslandEngineServiceClient(channelIsland);
        }
        public override Task<RpcVoid> ping(RpcVoid request, ServerCallContext context)
        {
            return Task.FromResult(new RpcVoid());
        }

        public override Task<RpcVoid> init(InitMessage request, ServerCallContext context)
        {
            Console.WriteLine($"UltiCharacterServiceImpl.init id={request.Id}");
            try
            {
                _ultiCharacter.init(request);
            }
            catch (Exception e)
            {
                Console.WriteLine($"UltiCharacterServiceImpl.sendEvent: Exception={e.Message}");
            }
            return Task.FromResult(new RpcVoid());
        }
    }
}