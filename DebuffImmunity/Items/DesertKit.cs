using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class DesertKit : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Desert Survival 101");
            Tooltip.SetDefault("Prevents Mighty Wind and Suffocation\n'Prepared for the sands!'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 30000;
            item.rare = 5;
            item.accessory = true;
            item.defense = 1;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Suffocation] = true;
            player.buffImmune[BuffID.WindPushed] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OnyxShard");
            recipe.AddIngredient(null, "SteelReed");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}