using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class SurvivalKit : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adventure Kit");
            Tooltip.SetDefault("Prevents Venom, Webbed, Suffocation, and Mighty Wind\n'Ready for adventure!'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.rare = 5;
            item.defense = 1;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Webbed] = true;
            player.buffImmune[BuffID.Suffocation] = true;
            player.buffImmune[BuffID.WindPushed] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DesertKit");
            recipe.AddIngredient(null, "SpiderKit");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}