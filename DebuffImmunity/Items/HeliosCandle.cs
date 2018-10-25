using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class HeliosCandle : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Helios' Candle");
            Tooltip.SetDefault("Prevents Ichor, Cursed Inferno, On Fire!, Frostburn, Shadowflame, Blackout, Feral Bite, and Moon Bite");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 100;
            item.value = 10000;
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Rabies] = true;
            player.buffImmune[BuffID.MoonLeech] = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Blackout] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "LeatherCandle");
            recipe.AddIngredient(null, "GreekBlankie");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}