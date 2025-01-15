using Com.Context.Grpc;
using Com.Island.Grpc;
using System;
using System.Reflection.Metadata;

namespace Agent1
{
    public class StylizedSceneBuilder
    {
        private const string gltfPath = "C:\\resources\\vkpbr1\\models\\ultimate-stylized-nature\\gltf\\";
        public static ItemSetMessage build()
        {
            var n = new ItemSetMessage() { Id = 0 };

            // n.Params.Add("cmd", "clear");

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 1, NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "BirchTree_1.gltf", GltfId = 1 }
                }
            });

            /*n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 2,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Petals_3.gltf", GltfId = 2 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 3,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Petals_4.gltf", GltfId = 3 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 4,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "PineTree_1.gltf", GltfId = 4 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 5,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "PineTree_2.gltf", GltfId = 5 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 6,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "PineTree_3.gltf", GltfId = 6 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 7,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "PineTree_5.gltf", GltfId = 7 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 8,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Plant_1.gltf", GltfId = 8 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 9,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Plant_2.gltf", GltfId = 9 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 10,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Plant_Flowers.gltf", GltfId = 10 }
                }
            });

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 11,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Rock_1.gltf", GltfId = 11 }
                }
            });

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 12,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Rock_2.gltf", GltfId = 12 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 13,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Rock_3.gltf", GltfId = 13 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 14,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Rock_4.gltf", GltfId = 14 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 15,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Rock_5.gltf", GltfId = 15 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 16,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "BirchTree_1.gltf", GltfId = 16 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 17,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "BirchTree_2.gltf", GltfId = 17 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 18,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "BirchTree_3.gltf", GltfId = 18 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 19,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "BirchTree_4.gltf", GltfId = 19 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 20,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "BirchTree_5.gltf", GltfId = 20 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 21,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Bush.gltf", GltfId = 21 }
                }
            });

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 22,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Bush_Flowers.gltf", GltfId = 22 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 23,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Bush_Large.gltf", GltfId = 23 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 24,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Bush_Large_Flowers.gltf", GltfId = 24 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 25,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Bush_Small.gltf", GltfId = 25 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 26,
                    NodeGroup = new NodeGroup() { GltfFilepath = gltfPath + "Bush_Small_Flowers.gltf", GltfId = 26 }
                }
            });*/
            // Bottom
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                NodeGroup = new NodeGroupContext()
                {
                    Id = 2000,
                    NodeGroup = new NodeGroup() { GltfFilepath = "C:/models/plane/gltf/plane2.gltf", GltfId = 2000 }
                }
            });

            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1001, Node = new Node() { GltfId = 1, NodeGroupId = 2000, Px = -2, Py = 0, Pz = 0 }
                }
            });
            /*n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1002,
                    Node = new Node() { GltfId = 2, NodeGroupId = 0, Px = -4, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1003,
                    Node = new Node() { GltfId = 3, NodeGroupId = 0, Px = 3, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1004,
                    Node = new Node() { GltfId = 4, NodeGroupId = 0, Px = 4, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1005,
                    Node = new Node() { GltfId = 5, NodeGroupId = 0, Px = 5, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1006,
                    Node = new Node() { GltfId = 6, NodeGroupId = 0, Px = 6, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1007,
                    Node = new Node() { GltfId = 7, NodeGroupId = 0, Px = 7, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1008,
                    Node = new Node() { GltfId = 8, NodeGroupId = 0, Px = 8, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1009,
                    Node = new Node() { GltfId = 9, NodeGroupId = 0, Px = 9, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1010,
                    Node = new Node() { GltfId = 10, NodeGroupId = 0, Px = 10, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1011,
                    Node = new Node() { GltfId = 11, NodeGroupId = 0, Px = 11, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1012,
                    Node = new Node() { GltfId = 12, NodeGroupId = 0, Px = 12, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1013,
                    Node = new Node() { GltfId = 13, NodeGroupId = 0, Px = 13, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1014,
                    Node = new Node() { GltfId = 14, NodeGroupId = 0, Px = 14, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1015,
                    Node = new Node() { GltfId = 15, NodeGroupId = 0, Px = 15, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1016,
                    Node = new Node() { GltfId = 16, NodeGroupId = 0, Px = 16, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1017,
                    Node = new Node() { GltfId = 17, NodeGroupId = 0, Px = 17, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1018,
                    Node = new Node() { GltfId = 18, NodeGroupId = 0, Px = 18, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1019,
                    Node = new Node() { GltfId = 19, NodeGroupId = 0, Px = 19, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1020,
                    Node = new Node() { GltfId = 20, NodeGroupId = 0, Px = 20, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1021,
                    Node = new Node() { GltfId = 21, NodeGroupId = 0, Px = 21, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 1022,
                    Node = new Node() { GltfId = 22, NodeGroupId = 0, Px = 22, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 3023,
                    Node = new Node() { GltfId = 23, NodeGroupId = 0, Px = 23, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 3024,
                    Node = new Node() { GltfId = 24, NodeGroupId = 0, Px = 24, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 3025,
                    Node = new Node() { GltfId = 25, NodeGroupId = 0, Px = 25, Py = 0, Pz = 0 }
                }
            });
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 3026,
                    Node = new Node() { GltfId = 26, NodeGroupId = 0, Px = 26, Py = 0, Pz = 0 }
                }
            });*/

            // Bottom
            n.CmdItems.Add(new CmdItem()
            {
                Cmd = CmdEnum.Insert,
                Node = new NodeContext()
                {
                    Id = 4000,
                    Node = new Node() { GltfId = 2000, NodeGroupId = 0, Px = 0, Py = 0, Pz = 0 }
                }
            });
            /*Random rnd = new Random();
            for (uint i = 0; i < 20; i=i+2) {
                for (uint s = 0; s < 20; s = s + 2) {
                    n.CmdItems.Add(new CmdItem()
                    {
                        Cmd = CmdEnum.Insert,
                        Node = new NodeContext()
                        {
                            Id = 10000 + i*100 + s,
                            // Node = new Node() { GltfId = (uint)rnd.Next(1, 26), NodeGroupId = 0, Px = i, Py = 0, Pz = s }
                            Node = new Node() { GltfId = (uint)1, NodeGroupId = 0, Px = i, Py = 0, Pz = s }
                        }
                    });
                }
            }*/

            /*"C:\models\ultimate-stylized-nature-1\gltf\.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Petals_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Petals_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PineTree_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PineTree_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PineTree_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PineTree_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Plant_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Plant_Flowers.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Rock_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Rock_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Rock_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Rock_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Rock_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\BirchTree_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\BirchTree_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\BirchTree_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\BirchTree_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\BirchTree_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Bush.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Bush_Flowers.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Bush_Large.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Bush_Large_Flowers.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Bush_Small.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Bush_Small_Flowers.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_6.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_7.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_8.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_9.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\DeadTree_10.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_1.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_1_Clump.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_1_Clump.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_2.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_2_Clump.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_2_Clump.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_3_Clump.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_3_Clump.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_4_Clump.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_4_Clump.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_5_Clump.bin"
            "C:\models\ultimate-stylized-nature-1\gltf\Flower_5_Clump.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Grass_Large.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Grass_Small.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\MapleTree_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\MapleTree_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\MapleTree_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\MapleTree_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\MapleTree_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\NormalTree_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\NormalTree_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\NormalTree_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\NormalTree_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\NormalTree_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PalmTree_1.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PalmTree_2.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PalmTree_3.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PalmTree_4.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\PalmTree_5.gltf"
            "C:\models\ultimate-stylized-nature-1\gltf\Petals_1.gltf"*/
            return n;
        }
    
    }
}
