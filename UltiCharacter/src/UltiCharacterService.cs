using Com.UltiCharacter.Grpc;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltiCharacter.src;

namespace UltiCharacter
{
    public class UltiCharacterService
    {
        private UltiCharacterModel model;

        // public AgentMollisService(ref OceanEngineClient oceanEngine)
        public UltiCharacterService()
        {
            // _oceanEngine = oceanEngine;
        }

        public void getModel(UInt32 id, ref UltiCharacterModel model) {
            model = this.model;
        }
        public void init(InitMessage initMessage)
        {
            // model = new SceneModel(ref _oceanEngine);
            model = new UltiCharacterModel();

            model.init(initMessage);
        }
        public void destroy(UInt32 id)
        {
            model = null;
        }
    }
}
