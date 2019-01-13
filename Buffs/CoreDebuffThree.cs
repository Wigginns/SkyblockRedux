//using SkyblockRedux.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace SkyblockRedux.Buffs
{
    public class CoreDebuffThree : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Core Debuff Level 3");
            Description.SetDefault("You are going to die!");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SkyblockReduxPlayer>().CoreDebuffThree = true;
            player.jumpBoost = false;
        }

        //public override void Update(NPC npc, ref int buffIndex)
        //{
        //   npc.GetGlobalNPC<SkyblockReduxGlobalNPC>().CoreDebuffOne = true;
        //}

    }
}
