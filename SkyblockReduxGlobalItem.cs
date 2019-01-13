using Terraria.ID;
using Terraria.ModLoader;

namespace SkyblockRedux
{
    public class SkyblockReduxGlobalItem : GlobalItem
    {
        //Override ExtractinatorUse to setup "loot" tables for extractinated items.
        public override void ExtractinatorUse(int extractType, ref int resultType, ref int resultStack)
        {

            int granite = ItemID.Granite;
            int dirt = ItemID.GraniteBlock;

            if (extractType == granite)
            {
                resultType = dirt;
                resultStack = 1;
            }
        }
    }
}
