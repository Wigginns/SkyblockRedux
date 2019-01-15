using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SkyblockRedux
{
    public class SkyblockReduxGlobalItem : GlobalItem
    {
        //Override ExtractinatorUse to setup "loot" tables for extractinated items.
        public override void ExtractinatorUse(int extractType, ref int resultType, ref int resultStack)
        {
            var player = Main.player[Main.myPlayer];

            if (extractType == (int)ItemID.Obsidian)
            {
                resultStack = Main.rand.Next(1) + 1;
                player.QuickSpawnItem(ItemID.StoneBlock, Main.rand.Next(4));
                switch (Main.rand.Next(4)) //returns 0-3
                {
                    case 0:
                        resultType = (int)ItemID.Diamond;
                        break;
                    case 1:
                        resultType = (int)ItemID.Emerald;
                        break;
                    case 2:
                        resultType = (int)ItemID.Ruby;
                        break;
                    case 3:
                    default:
                        resultType = (int)ItemID.Sapphire;
                        break;
                }
            }
            
        }
    }
}
