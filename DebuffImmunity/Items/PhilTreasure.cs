using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class PhilTreasure : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Philosopher's Treasure");
            Tooltip.SetDefault("Prevents Mana Sickness");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.value = 100000;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ManaSickness] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PhilosophersStone);
            recipe.AddIngredient(ItemID.LunarBar, 3);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
