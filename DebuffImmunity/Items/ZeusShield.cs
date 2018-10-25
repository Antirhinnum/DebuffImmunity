using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class ZeusShield : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zeus' Escutcheon");
            Tooltip.SetDefault("Prevents nearly all debuffs, knockback, and fire blocks\n'Go forth, and conquer'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 200000;
            item.rare = 11;
            item.accessory = true;
            item.defense = 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.Frozen] = true;
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
            player.buffImmune[BuffID.ManaSickness] = true;
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.ChaosState] = true;
            player.buffImmune[BuffID.WitheredArmor] = true;
            player.buffImmune[BuffID.WitheredWeapon] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.noKnockback = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AnkhShield);
            recipe.AddIngredient(null, "OtherShield");
            recipe.AddIngredient(null, "DemigodBlessing");
            recipe.AddIngredient(null, "WarmMirror");
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}