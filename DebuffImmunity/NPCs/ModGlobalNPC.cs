using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.NPCs
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            Player player = Main.player[Main.myPlayer];
            switch (type)
            {
                case NPCID.TravellingMerchant:
                    {
                        if (Main.rand.Next(10) == 0)
                        {
                            shop.item[nextSlot].SetDefaults(mod.ItemType("PaperFan"));
                            nextSlot++;
                        }
                    }
                    break;
            }
        }
        public override void NPCLoot(NPC npc)
        {
            //The if (Main.rand.Next(x) == 0) determines how rare the drop is. To find the percent of a drop, divide 100 by your desired percent, minus the percent sign. Ex: A 2% chance would be 100% / 2(%), or 50. This is what you put in place of x.
            if (Main.expertMode) //If in an Expert Mode World...
            {
                if (Main.rand.Next(50) == 0) //2% chance
                {
                    if (npc.type == NPCID.BlackRecluse || npc.type == NPCID.DesertScorpionWalk || npc.type == NPCID.DesertScorpionWall || npc.type == NPCID.BlackRecluseWall)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Antivenom"));
                    }
                }
                if (Main.rand.Next(50) == 0) //2% chance
                {
                    if (npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSword || npc.type == NPCID.MeteorHead || npc.type == NPCID.FireImp)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FireBlanket"));
                    }
                }
                if (Main.rand.Next(15) == 0) //~6.67% chance
                {
                    if (npc.type == NPCID.RaggedCaster || npc.type == NPCID.RaggedCasterOpenCoat)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HopefulCandle"));
                    }
                }
                if (Main.rand.Next(50) == 0) //2% chance
                {
                    if (npc.type == NPCID.Clinger || npc.type == NPCID.IchorSticker)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GreekBlood"));
                    }
                }
                if (Main.rand.Next(50) == 0) //2% chance
                {
                    if (npc.type == NPCID.MartianEngineer || npc.type == NPCID.MartianTurret)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LightningRod"));
                    }
                }
                if (Main.rand.Next(50) == 0) //2% chance
                {
                    if (npc.type == NPCID.ChaosElemental)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DiscordRing"));
                    }
                }
                if (Main.rand.Next(15) == 0) //~6.67% chance
                {
                    if (npc.type == NPCID.SandElemental || npc.type == NPCID.SandShark || npc.type == NPCID.SandsharkCorrupt || npc.type == NPCID.SandsharkCrimson || npc.type == NPCID.SandsharkHallow || npc.type == NPCID.Tumbleweed)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OnyxShard"));
                    }
                }
            }
            else if (!Main.expertMode) //If in a Normal Mode world...
            {
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    if (npc.type == NPCID.BlackRecluse || npc.type == NPCID.DesertScorpionWalk || npc.type == NPCID.DesertScorpionWall || npc.type == NPCID.BlackRecluseWall)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Antivenom"));
                    }
                }
                if (Main.rand.Next(10) == 0) //10% chance
                {
                    if (npc.type == NPCID.DD2Betsy)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BetsyShield"));
                    }
                }
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    if (npc.type == NPCID.HellArmoredBones || npc.type == NPCID.HellArmoredBonesSpikeShield || npc.type == NPCID.HellArmoredBonesMace || npc.type == NPCID.HellArmoredBonesSword || npc.type == NPCID.MeteorHead || npc.type == NPCID.FireImp)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("FireBlanket"));
                    }
                }
                if (Main.rand.Next(20) == 0) //5% chance
                {
                    if (npc.type == NPCID.RaggedCaster || npc.type == NPCID.RaggedCasterOpenCoat)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HopefulCandle"));
                    }
                }
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    if (npc.type == NPCID.Clinger || npc.type == NPCID.IchorSticker)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GreekBlood"));
                    }
                }
                if (Main.rand.Next(10) == 0) //10% chanxe
                {
                    if (npc.type == NPCID.MoonLordCore)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LunarUmbrella"));
                    }
                }
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    if (npc.type == NPCID.MartianEngineer || npc.type == NPCID.MartianTurret)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LightningRod"));
                    }
                }
                if (Main.rand.Next(100) == 0) //1% chance
                {
                    if (npc.type == NPCID.ChaosElemental)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DiscordRing"));
                    }
                }
                if (Main.rand.Next(20) == 0) //5% chance
                {
                    if (npc.type == NPCID.SandElemental || npc.type == NPCID.SandShark || npc.type == NPCID.SandsharkCorrupt || npc.type == NPCID.SandsharkCrimson || npc.type == NPCID.SandsharkHallow || npc.type == NPCID.Tumbleweed)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OnyxShard"));
                    }
                }
            }
        }
    }
}