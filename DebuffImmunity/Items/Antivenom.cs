using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class Antivenom : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Antivenom");
            Tooltip.SetDefault("Prevents Venom");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Venom] = true;
        }
    }
}
