using System;
using Com.Scene.Grpc;
using Grpc.Core;

namespace Scene
{
    class Program
    {
        const string host = "127.0.0.1";
        private static int port = 67835;
        private static Server server;

        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Equals("--port"))
                {
                    port = Int32.Parse(args[i + 1]);
                    break;
                }
            }
            var options = new[] {
                new ChannelOption("grpc.default_compression_level", (int)CompressionLevel.Low),
                new ChannelOption("grpc.max_receive_message_length", 2000000)
            };
            server = new Server(options)
            {
                Services = { SceneEngineService.BindService(new SceneServiceImpl()) },
                Ports = { new ServerPort(host, port, ServerCredentials.Insecure) }
            };
            server.Start();
            Console.WriteLine("SceneServer listening on port " + port);
            Console.ReadKey();
        }
    }
}