using Com.Island.Grpc;
using Com.Scene.Grpc;
using Google.Protobuf.Collections;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scene
{
    public class SceneService
    {
        private SceneModel model;

        private NameValueCollection config;
        const string host = "localhost";
        private static int portIsland = 67589;

        private static IslandEngineService.IslandEngineServiceClient _island;
        private static Channel channelIsland;

        public SceneService() {
            channelIsland = new Channel($"{host}:{portIsland}", ChannelCredentials.Insecure);

            _island = new IslandEngineService.IslandEngineServiceClient(channelIsland);
        }

        public void getModel(UInt32 id, ref SceneModel model) {
            model = this.model;
        }
        public void init(InitScene initScene) {
            if (model != null && model.systemModel.Id == initScene.Id)
                throw new Exception($"scene.id = {initScene.Id} already exists");

            model = new SceneModel(ref _island);

            model.init(initScene);
        }

        public void restart(UInt32 id)
        {
            if (model == null || model.systemModel.Id != id)
                throw new Exception($"scene.id = {id} not found");

            model.restart();
        }
        public void destroy(UInt32 id) {
            model = null;
        }
    }
}
