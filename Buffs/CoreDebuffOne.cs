//using SkyblockRedux.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace SkyblockRedux.Buffs
{
    public class CoreDebuffOne : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Core Debuff Level 1");
            Description.SetDefault("You feel slightly heavier");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SkyblockReduxPlayer>().CoreDebuffOne = true;
        }

        //public override void Update(NPC npc, ref int buffIndex)
        //{
        //   npc.GetGlobalNPC<SkyblockReduxGlobalNPC>().CoreDebuffOne = true;
        //}

    }
}
