using Com.Context.Grpc;
using Com.Island.Grpc;
using System;
using System.Reflection.Metadata;

namespace Agent1
{
    public class StylizedItemBuilder
    {
        private const string gltfPath = "C:\\resources\\vkpbr1\\models\\stylized-barrel\\stylized-barrel.gltf";
        public static ItemSetMessage build()
        {
            var n = new ItemSetMessage() { Id = 0 };

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 3408059143, 
                    NodeGroup = new NodeGroup() { 
                        GltfFilepath = gltfPath, GltfId = 2781667236
                    }
                }
            });

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 3299617548, 
                    Node = new Node() { 
                        GltfId = 2781667236, 
                        NodeGroupId = 3408059143, 
                        Px = 2.5f, 
                        Py = 0, 
                        Pz = 2.5f
                    }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1517883070,
                    Node = new Node()
                    {
                        GltfId = 2781667236,
                        NodeGroupId = 3408059143,
                        Px = 1.5f,
                        Py = 0,
                        Pz = 3.5f
                    }
                }
            });

            return n;
        }
    
    }
}
