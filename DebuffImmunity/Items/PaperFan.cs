using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class PaperFan : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Paper Fan");
            Tooltip.SetDefault("Prevents Lovestruck, Stinky, Slimed, and Wet");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 200;
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Lovestruck] = true;
            player.buffImmune[BuffID.Stinky] = true;
            player.buffImmune[BuffID.Slimed] = true;
            player.buffImmune[BuffID.Wet] = true;
        }
    }
}