using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class DemigodBlessing : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Demigod's Blessing");
            Tooltip.SetDefault("Prevents Wet, Stinky, Slimy, Lovestruck, Ichor, Cursed Inferno, On Fire!, Frostburn, Shadowflame, Feral Bite, Moon Bite, Blackout, Venom, Webbed, Mighty Wind, and Suffocation\n'May the gods bless you...'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 100;
            item.value = 150000;
            item.rare = 11;
            item.defense = 3;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Wet] = true;
            player.buffImmune[BuffID.Stinky] = true;
            player.buffImmune[BuffID.Slimed] = true;
            player.buffImmune[BuffID.Lovestruck] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
            player.buffImmune[BuffID.Rabies] = true;
            player.buffImmune[BuffID.MoonLeech] = true;
            player.buffImmune[BuffID.Blackout] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Webbed] = true;
            player.buffImmune[BuffID.WindPushed] = true;
            player.buffImmune[BuffID.Suffocation] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PaperFan");
            recipe.AddIngredient(null, "HeliosCandle");
            recipe.AddIngredient(null, "SurvivalKit");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
