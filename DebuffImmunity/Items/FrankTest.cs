using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class FrankTest : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Franklin's Test");
            Tooltip.SetDefault("Prevents Electrified, Distorted, and Obstructed");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 50000;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
            player.buffImmune[BuffID.Electrified] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LunarUmbrella");
            recipe.AddIngredient(null, "LightningRod");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}