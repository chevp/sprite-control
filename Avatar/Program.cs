using System;
using Com.Ipcoe1.Grpc;
using Grpc.Core;

namespace AvatarApi
{
    class Program
    {
        const string host = "127.0.0.1";
        private static int port = 67334;
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
                Services = { IPCOE1Service.BindService(new AvatarServiceImpl()) },
                Ports = { new ServerPort(host, port, ServerCredentials.Insecure) }
            };
            server.Start();
            Console.WriteLine("AvatarServer listening on port " + port);
            Console.ReadKey();
        }
    }
}