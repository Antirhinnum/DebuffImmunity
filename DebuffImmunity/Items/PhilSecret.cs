using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class PhilSecret : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Philosopher's Secret");
            Tooltip.SetDefault("Prevents Mana Sickness and Chaos State");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 10000;
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ManaSickness] = true;
            player.buffImmune[BuffID.ChaosState] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "DiscordRing");
            recipe.AddIngredient(null, "PhilTreasure");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}