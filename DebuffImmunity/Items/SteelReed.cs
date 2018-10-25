using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class SteelReed : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Steel Reed");
            Tooltip.SetDefault("Prevents Suffocation");
        }

        public override void SetDefaults()
        {
            item.width = 68;
            item.height = 68;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Suffocation] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("DebuffImmunity:Iron", 5);
            recipe.AddRecipeGroup("DebuffImmunity:Steel", 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
