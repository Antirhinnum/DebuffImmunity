using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class GreekBlankie : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Greek Blankie");
            Tooltip.SetDefault("Prevents Ichor, Cursed Inferno, On Fire!, Frostburn, and Shadowflame");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 30000;
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GreekBlood");
            recipe.AddIngredient(null, "MagicBlanket");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}