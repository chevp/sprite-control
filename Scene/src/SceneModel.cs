using Com.Island.Grpc;
using Com.Scene.Grpc;
using Google.Protobuf.Collections;
using Stateless;
using System;

namespace Scene
{
    public class SceneModel
    {
        private StateMachine<State, Trigger> machine =
            new StateMachine<State, Trigger>(State.Unspecified);

        public SystemModel systemModel;

        private IslandEngineService.IslandEngineServiceClient _island;

        private StateMachine<State, Trigger>.TriggerWithParameters<InitScene> initTrigger { get; }
        // private StateMachine<State, Trigger>.TriggerWithParameters<Com.GameEngine.Grpc.Node, string, uint> updateTrigger { get; }

        public SceneModel(ref IslandEngineService.IslandEngineServiceClient island)
        {
            systemModel = new SystemModel();
            _island = island;

            initTrigger = machine.SetTriggerParameters<InitScene>(Trigger.Init);

            machine.Configure(State.Unspecified)
                .Permit(Trigger.Init, State.Idle)
                .OnEntry(entryAction).OnExit(exitAction);

            machine.Configure(State.Idle)
                //.Permit(Trigger.Run, State.Run)
                .OnEntryFrom(initTrigger, loadModel)
                .OnEntry(entryAction).OnExit(exitAction);

            machine.Configure(State.Idle)
            .PermitReentry(Trigger.Restart)
            .OnEntryFrom(Trigger.Restart, reloadModel)
            .OnEntry(entryAction).OnExit(exitAction);

            /*machine.Configure(State.Run)
                .Permit(Trigger.Stop, State.Idle)
                .OnEntry(entryAction).OnExit(exitAction);*/
        }

        private void reloadModel()
        {
            loadModel(new InitScene() { 
                Id = systemModel.Id, 
                RscSceneId = systemModel.RscSceneId });
        }

        private void loadModel(InitScene initScene)
        {
            systemModel.Id = initScene.Id;

            var n = new ItemSetMessage() { Id = 3986538186 };

            n.Params.Add("cmd", "clear");

            // Map
            n.CmdItems.AddRange(Agent1.StylizedSceneBuilder.build().CmdItems);
            // or load from AgentMollis!

            // Avatar
            n.CmdItems.AddRange(Agent1.AvatarSciFiBuilder.build().CmdItems);

            // Items
            n.CmdItems.AddRange(Agent1.StylizedItemBuilder.build().CmdItems);

            // Send to Clients
            _island.putItemSetMessage(n);
        }

        private void entryAction()
        {
            switch (machine.State)
            {
                case State.Idle:
                    //systemModel.Animation = 4;
                    //systemModel.Vel = new FVec3() { X = 0, Y = 0, Z = 0 };
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
                    break;
            }
        }
        
        private void exitAction()
        {
            switch (machine.State)
            {
                case State.Idle:
                // case State.Run:
                    break;
            }
        }
        public void init(InitScene initScene)
        {
            machine.Fire(initTrigger, initScene);
        }
        public void restart()
        {
            machine.Fire(Trigger.Restart);
        }
        public string getState()
        {
            return machine.State.ToString();
        }
        public void stop()
        {
            // machine.Fire(Trigger.Stop);
        }
        public void run()
        {
            // machine.Fire(Trigger.Run);
        }
    }
}
