using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class DiscordRing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Discordant Ring");
            Tooltip.SetDefault("Prevents Chaos State");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 12;
            item.value = 10000;
            item.rare = 6;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ChaosState] = true;
        }
    }
}
