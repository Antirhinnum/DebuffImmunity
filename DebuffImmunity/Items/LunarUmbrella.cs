using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class LunarUmbrella : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Umbrella");
            Tooltip.SetDefault("Prevents Obstructed and Distorted");
        }

        public override void SetDefaults()
        {
            item.width = 62;
            item.height = 66;
            item.value = 100000;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
        }
    }
}