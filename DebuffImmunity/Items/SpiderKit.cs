using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class SpiderKit : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spider Kit");
            Tooltip.SetDefault("Prevents Venom and Webbed");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 16;
            item.value = 10000;
            item.rare = 5;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Webbed] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StylistKilLaKillScissorsIWish);
            recipe.AddIngredient(null, "Antivenom");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}