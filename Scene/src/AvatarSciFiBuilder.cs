using Com.Context.Grpc;
using Com.Island.Grpc;
using System;
using System.Reflection.Metadata;

namespace Agent1
{
    public class AvatarSciFiBuilder
    {
        // private const string gltfSpriteFullpath = "C:\\resources\\vkpbr1\\models\\ultimate-modular-women\\gltf\\SciFi.gltf";
        private const string gltfSpriteFullpath = "C:\\resources\\vkpbr1\\models\\stylized-barrel\\stylized-barrel.gltf";

        public static ItemSetMessage build()
        {
            var n = new ItemSetMessage() { Id = 0 };

            // Sprite NodeGroup
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 1874460129,
                    NodeGroup = new NodeGroup()
                    {
                        GltfFilepath = gltfSpriteFullpath,
                        GltfId = 3440829812
                    }
                }
            });

            // Sprite Node
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 2953077889,
                    Node = new Node()
                    {
                        GltfId = 3440829812,
                        NodeGroupId = 0,
                        Px = 0,
                        Py = 0,
                        Pz = 0
                    }
                }
            });

            return n;
        }

    }
}
