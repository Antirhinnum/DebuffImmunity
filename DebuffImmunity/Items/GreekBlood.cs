using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class GreekBlood : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood of the Greek");
            Tooltip.SetDefault("Prevents Cursed Inferno and Ichor");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 24;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
        }
    }
}
