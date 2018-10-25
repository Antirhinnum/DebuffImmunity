using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class FireBlanket : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Blanket");
            Tooltip.SetDefault("Prevents On Fire!");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 26;
            item.value = 10000;
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
        }
    }
}
