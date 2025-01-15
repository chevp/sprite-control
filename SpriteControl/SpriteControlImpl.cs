using Com.CmsEngine.Grpc;
using Com.Context.Grpc;
using Com.Island.Grpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Agent1
{
    public class SpriteControlImpl
    {
        const string host = "localhost";
        private static int portIsland = 67589;

        private static IslandEngineService.IslandEngineServiceClient _island;
        private static Channel channelIsland;

        private static HashSet<IServerStreamWriter<Elmnt>> responseStreamsElmnt =
            new HashSet<IServerStreamWriter<Elmnt>>();

        private const string gltfStylizedNaturePath = "C:\\resources\\vkpbr1\\models\\ultimate-stylized-nature\\gltf\\";
        private const string gltfSpriteFullpath = "C:\\resources\\vkpbr1\\models\\ultimate-modular-women\\gltf\\SciFi.gltf";

        public SpriteControlImpl()
        {
            channelIsland = new Channel($"{host}:{portIsland}", ChannelCredentials.Insecure);
            _island = new IslandEngineService.IslandEngineServiceClient(channelIsland);

            bool isRunning = false;
            Stopwatch stopWatch = new Stopwatch();

            while (true)
            {
                try
                {
                    if (!isRunning)
                    {
                        run();

                        isRunning = true;
                        stopWatch.Start();
                    }
                    if (stopWatch.ElapsedMilliseconds > 5000)
                    {
                        loop();

                        stopWatch.Restart();
                    }
                }
                catch (RpcException e)
                {
                    Console.WriteLine("Agent1Impl.constructor RpcException: " + e.Message);

                    isRunning = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Agent1Impl.constructor Exception: " + e.Message);

                    break;
                }
                Thread.Sleep(5000);
            }
        }
        private static double getUNXTimestamp()
        {
            TimeSpan span = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc));
            return span.TotalMilliseconds;
        }

        private void run()
        {
            // _thasos.get(new Com.CmsEngine.Grpc.Ident() { Id = "5fd76e2b" });
            // 5fd76e2b = 1607953963

            subscribeToIslandEvents(1607953963);

            initScene();
        }

        private async void subscribeToIslandEvents(uint id)
        {
            AsyncServerStreamingCall<EventMessage> _call;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                try
                {
                    using (_call = _island.subscribeEvent(new Com.Common.Grpc.Ident { Id = id }))
                    {
                        while (await _call.ResponseStream.MoveNext(CancellationToken.None))
                        {
                            var serverMessage = _call.ResponseStream.Current;

                            Console.WriteLine($"subscribeToIslandEvents: Received Response for " +
                                $"id={serverMessage.Id}");

                            takeAction(serverMessage);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"subscribeToIslandEvents: Exception={e.Message}");
                }

                Console.WriteLine($"subscribeToIslandEvents: try to reconnect");

                await Task.Delay(1000);
            }
        }

        private void takeAction(EventMessage eventMsg)
        {
            Console.WriteLine($"Agent1Impl.takeAction: please do something");
        }
        private void loop() { }

        private static ItemSetMessage buildScene1() {
            
            var n = new ItemSetMessage() { Id = 0 };

            n.Params.Add("cmd", "clear");

            n.CmdItems.Add(new CmdItem()
                {
                    Cmd = CmdEnum.Insert,
                    NodeGroup = new NodeGroupContext()
                    {
                        Id = 1,
                        NodeGroup = new NodeGroup() { 
                            GltfFilepath = gltfStylizedNaturePath + "Petals_2.gltf", 
                            GltfId = 1
                        }
                    }
                });

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 1,
                    NodeGroup = new NodeGroup()
                    {
                        GltfFilepath = gltfSpriteFullpath,
                        GltfId = 2
                    }
                }
            });

            // Sprite
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1,
                    Node = new Node() { 
                        GltfId = 2, 
                        NodeGroupId = 0, 
                        Px = 0, Py = 0, Pz = 0 }
                }
            });

            // Pedal
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 2,
                    Node = new Node()
                    {
                        GltfId = 1,
                        NodeGroupId = 0,
                        Px = 4.5f,
                        Py = 0,
                        Pz = 4.0f
                    }
                }
            });

            // Bottom
            n.CmdItems.Add(new CmdItem()
                {
                    Cmd = CmdEnum.Insert,
                    NodeGroup = new NodeGroupContext()
                    {
                        Id = 2000,
                        NodeGroup = new NodeGroup() { 
                            GltfFilepath = "C:/models/plane/gltf/plane2.gltf", 
                            GltfId = 2000 }
                    }
                });
            n.CmdItems.Add(new CmdItem()
                {
                    Cmd = CmdEnum.Insert,
                    Node = new NodeContext()
                    {
                        Id = 4000,
                        Node = new Node() { 
                            GltfId = 2000, 
                            NodeGroupId = 0, 
                            Px = 0, Py = 0, Pz = 0 }
                    }
                });

                return n;
        }
        private void initScene()
        {
            try
            {
                var n = buildScene1();

                _island.putItemSetMessage(n);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Agent1Impl.doPeriodicAction: Exception={e.Message}");
            }
        }
    }
}