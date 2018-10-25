using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class BossBags : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "bossBag" && arg == ItemID.MoonLordBossBag)
            {
                if (Main.rand.Next(6) == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("LunarUmbrella"));
                }
            }

            if (context == "bossBag" && arg == ItemID.BossBagBetsy)
            {
                if (Main.rand.Next(6) == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("BetsyShield"));
                }
            }
        }
    }
}
