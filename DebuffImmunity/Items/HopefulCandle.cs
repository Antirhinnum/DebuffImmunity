using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class HopefulCandle : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hopeful Candle");
            Tooltip.SetDefault("Prevents Blackout\n'A light in the dark...'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.rare = 7;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Blackout] = true;
        }
    }
}