using Com.UltiCharacter.Grpc;
using Google.Protobuf.Collections;
using Stateless;
using System;

namespace UltiCharacter.src
{
    public class UltiCharacterModel
    {
        private StateMachine<State, Trigger> machine =
            new StateMachine<State, Trigger>(State.Unspecified);

        private SystemModel systemModel;

        // private OceanEngineClient _oceanEngine;

        // public StaticObjectService _staticObjectService;

        private StateMachine<State, Trigger>.TriggerWithParameters<InitMessage> initTrigger { get; }
        // private StateMachine<State, Trigger>.TriggerWithParameters<Com.GameEngine.Grpc.Node, string, uint> updateTrigger { get; }

        // public SceneModel(ref OceanEngineClient oceanEngine)
        public UltiCharacterModel()
        {
            systemModel = new SystemModel();
            //_oceanEngine = oceanEngine;
            //_staticObjectService = new StaticObjectService(ref _oceanEngine);

            initTrigger = machine.SetTriggerParameters<InitMessage>(Trigger.Init);

            machine.Configure(State.Unspecified)
                .Permit(Trigger.Init, State.Idle)
                .OnEntry(entryAction).OnExit(exitAction);

            machine.Configure(State.Idle)
                .Permit(Trigger.Run, State.Run)
                .OnEntryFrom(initTrigger, loadModel)
                .OnEntry(entryAction).OnExit(exitAction);

            machine.Configure(State.Run)
                .Permit(Trigger.Stop, State.Idle)
                .OnEntry(entryAction).OnExit(exitAction);
        }

        private void loadModel(InitMessage initMessage)
        {
            systemModel.Id = initMessage.Id;
        }

        private void entryAction()
        {
            switch (machine.State)
            {
                case State.Idle:
                    systemModel.Animation = 4;
                    systemModel.Vel = new FVec3() { X = 0, Y = 0, Z = 0 };
                    break;
                case State.Walk:
                    systemModel.Animation = 12;
                    break;
                default:
                    break;
            }
        }
        private void doAction()
        {
            switch (machine.State)
            {
                case State.Idle:
                case State.Run:
                    break;
            }
        }
        
        private void exitAction()
        {
            switch (machine.State)
            {
                case State.Idle:
                case State.Run:
                    break;
            }
        }
        public void init(InitMessage initMessage)
        {
            machine.Fire(initTrigger, initMessage);
        }
        public string getState()
        {
            return machine.State.ToString();
        }
        public void stop()
        {
            machine.Fire(Trigger.Stop);
        }
        public void run()
        {
            machine.Fire(Trigger.Run);
        }
    }
}
