using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class LightningRod : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Rod");
            Tooltip.SetDefault("Prevents Electrified");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = 10000;
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Electrified] = true;
        }
    }
}
