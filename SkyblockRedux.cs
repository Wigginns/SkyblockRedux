using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;


namespace SkyblockRedux
{
    class SkyblockRedux : Mod
    {
        public SkyblockRedux()
        {
        }

        public override void Load()
        {
            //Add Items we want to be able to extractinate to ExtractinatorMode Set
            ItemID.Sets.ExtractinatorMode[ItemID.Obsidian] = ItemID.Obsidian;
        }

        public override void Unload()
        {
            //Revert additions to Extractinator mode in Load()
            ItemID.Sets.ExtractinatorMode[ItemID.Obsidian] = 0;
        }

    }

}

