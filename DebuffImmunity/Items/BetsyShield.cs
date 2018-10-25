using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class BetsyShield : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Etherian Shield");
            Tooltip.SetDefault("Prevents Etherian Debuffs");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 30;
            item.value = 100000;
            item.rare = 8;
            item.defense = 2;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.WitheredArmor] = true;
            player.buffImmune[BuffID.WitheredWeapon] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.noKnockback = true;
        }


    }
}
