//using SkyblockRedux.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace SkyblockRedux.Buffs
{
    public class CoreDebuffTwo : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Core Debuff Level 2");
            Description.SetDefault("You much heavier!");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SkyblockReduxPlayer>().CoreDebuffTwo = true;
            
        }

        //public override void Update(NPC npc, ref int buffIndex)
        //{
        //   npc.GetGlobalNPC<SkyblockReduxGlobalNPC>().CoreDebuffOne = true;
        //}

    }
}
