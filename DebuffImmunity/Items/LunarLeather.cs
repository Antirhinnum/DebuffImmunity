using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class LunarLeather : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lunar Leather");
            Tooltip.SetDefault("Prevents Feral Bite and Moon Bite");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Rabies] = true;
            player.buffImmune[BuffID.MoonLeech] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 3);
            recipe.AddIngredient(null, "LeatherWrap");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}