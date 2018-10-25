using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class MagicBlanket : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magical Blanket");
            Tooltip.SetDefault("Prevents On Fire!, Frostburn, and Shadowflame");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 26;
            item.value = 10000;
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FireBlanket");
            recipe.AddIngredient(ItemID.CrystalShard, 7);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}