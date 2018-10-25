using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity
{
    public class DebuffImmunity : Mod
    {
        internal static DebuffImmunity instance;

        public DebuffImmunity()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            };
        }

        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => "Any Iron Bar", new int[]
            {
                ItemID.IronBar,
                ItemID.LeadBar
            });
            RecipeGroup.RegisterGroup("DebuffImmunity:Iron", group);

            group = new RecipeGroup(() => "Any Adamantite Bar", new int[]
            {
                ItemID.AdamantiteBar,
                ItemID.TitaniumBar
            });
            RecipeGroup.RegisterGroup("DebuffImmunity:Steel", group);
        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Vertebrae, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.Leather);
            recipe.AddRecipe();
        }
    }
}