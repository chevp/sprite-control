using Com.Ipcoe1.Grpc;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatarApi
{
    public class AvatarService
    {
        private AvatarModel model;

        // Hier müsste eine Liste sein!

        // public AgentMollisService(ref OceanEngineClient oceanEngine)
        public AvatarService()
        {
            // _oceanEngine = oceanEngine;
        }

        private void getModel(UInt32 id, ref AvatarModel model) {
            model = this.model;
        }
        public Value sendEvent(Dictionary cmd, Value value) {
            switch (cmd)
            {
                case Dictionary.Init:
                    init(value.StructValue);
                    break;
                case Dictionary.CurrentState:
                    return new Value() { StringValue = model.getState() };
                case Dictionary.Run:
                    model.run();
                    break;
                case Dictionary.Stop:
                    model.stop();
                    break;
                case Dictionary.Remove:
                    destroy(0);
                    break;
                case Dictionary.Select:
                    return new Value() { StructValue = model.getGraphicalNode() };
            }
            return new Value();
        }
        private void init(Struct initMessage)
        {
            // model = new SceneModel(ref _oceanEngine);
            model = new AvatarModel();

            model.init(initMessage);
        }
        private void destroy(UInt32 id)
        {
            model = null;
        }
    }
}
