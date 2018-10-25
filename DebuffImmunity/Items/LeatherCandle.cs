using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class LeatherCandle : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leather Light");
            Tooltip.SetDefault("Prevents Blackout, Feral Bite, and Moon Bite");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 30000;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Rabies] = true;
            player.buffImmune[BuffID.MoonLeech] = true;
            player.buffImmune[BuffID.Blackout] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LunarLeather");
            recipe.AddIngredient(null, "HopefulCandle");
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}