using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DebuffImmunity.Items
{
    public class OnyxShard : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Onyx Shard");
            Tooltip.SetDefault("Prevents Mighty Wind");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.value = 10000;
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.WindPushed] = true;
        }
    }
}