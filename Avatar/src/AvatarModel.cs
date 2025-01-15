using Com.Ipcoe1.Grpc;
using Google.Protobuf.Collections;
using Stateless;
using System;
using System.Threading.Tasks;

namespace AvatarApi
{
    public class AvatarModel
    {
        class SystemModel {
            public uint id { get; set; }
            public Vector3f pos { get; set; }
            public Vector3f rot { get; set; }
            public Vector3f vel { get; set; }
            public uint animation { get; set; }
            public float animationTimer { get; set; }
            public uint gltfId { get; set; }
        }
        enum State {
            UNSPECIFIED,
            READY,
            IDLE,
            WALK,
            RUN
        }
        enum Trigger {
            UNSPECIFIED,
            STOP,
            RUN,
            WALK,
            INIT
        }
        
        private StateMachine<State, Trigger> machine =
            new StateMachine<State, Trigger>(State.UNSPECIFIED);

        private SystemModel systemModel;

        // private OceanEngineClient _oceanEngine;

        // public StaticObjectService _staticObjectService;

        private StateMachine<State, Trigger>.TriggerWithParameters<Struct> initTrigger { get; }
        // private StateMachine<State, Trigger>.TriggerWithParameters<Com.GameEngine.Grpc.Node, string, uint> updateTrigger { get; }

        // public SceneModel(ref OceanEngineClient oceanEngine)
        public AvatarModel()
        {
            systemModel = new SystemModel();
            //_oceanEngine = oceanEngine;
            //_staticObjectService = new StaticObjectService(ref _oceanEngine);

            initTrigger = machine.SetTriggerParameters<Struct>(Trigger.INIT);

            machine.Configure(State.UNSPECIFIED)
                .Permit(Trigger.INIT, State.IDLE)
                .OnEntry(entryAction).OnExit(exitAction);

            machine.Configure(State.IDLE)
                .Permit(Trigger.RUN, State.RUN)
                .OnEntryFrom(initTrigger, loadModel)
                .OnEntry(entryAction).OnExit(exitAction);

            machine.Configure(State.RUN)
                .Permit(Trigger.STOP, State.IDLE)
                .OnEntry(entryAction).OnExit(exitAction);
        }

        private void loadModel(Struct initMessage)
        {
            systemModel = new SystemModel();
            initMessage.Value.TryGetValue("id", out Value id);
            systemModel.id = id.Uint32Value;
            systemModel.pos = new Vector3f();
        }

        private void entryAction()
        {
            switch (machine.State)
            {
                case State.IDLE:
                    systemModel.animation = 4;
                    systemModel.vel = new Vector3f() { X = 0, Y = 0, Z = 0 };
                    break;
                case State.RUN:
                    systemModel.animation = 12;
                    Task taskA = new Task(() => {
                        while (machine.State == State.RUN) {
                            systemModel.pos.X += 0.000001f;
                            Task.Delay(2000);
                        }
                    });
                    taskA.Start();
                    break;
                default:
                    break;
            }
        }
        private void doAction()
        {
            switch (machine.State)
            {
                case State.IDLE:
                case State.RUN:
                    break;
            }
        }
        
        private void exitAction()
        {
            switch (machine.State)
            {
                case State.IDLE:
                case State.RUN:
                    break;
            }
        }
        public void init(Struct initMessage)
        {
            machine.Fire(initTrigger, initMessage);
        }
        public string getState()
        {
            return machine.State.ToString();
        }
        public void stop()
        {
            machine.Fire(Trigger.STOP);
        }
        public void run()
        {
            machine.Fire(Trigger.RUN);
        }
        public Struct getGraphicalNode() {
            var a = new Struct();
            a.Value.Add("id",       new Value() { Uint32Value = systemModel.id });
            a.Value.Add("gId",   new Value() { Uint32Value = systemModel.gltfId });
            a.Value.Add("p",      new Value() { Vector3FValue = systemModel.pos });
            a.Value.Add("r",      new Value() { Vector3FValue = systemModel.rot });
            a.Value.Add("a",       new Value() { FloatValue = systemModel.animationTimer });
            return a;
        }
    }
}