using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class OtherShield : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Otherworldly Shield");
            Tooltip.SetDefault("Prevents Mana Sickness, Chaos State, Electrified, Obstructed, Distorted, Withered Armor, Withered Weapon, and Oozed\nPrevents knockback");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 100;
            item.value = 75000;
            item.rare = 11;
            item.defense = 4;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.ManaSickness] = true;
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.ChaosState] = true;
            player.buffImmune[BuffID.WitheredArmor] = true;
            player.buffImmune[BuffID.WitheredWeapon] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.noKnockback = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PhilSecret");
            recipe.AddIngredient(null, "FrankTest");
            recipe.AddIngredient(null, "BetsyShield");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}