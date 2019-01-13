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
    class SkyblockReduxPlayer : ModPlayer
    {
        public bool CoreDebuffOne = false;
        public bool CoreDebuffTwo = false;
        public bool CoreDebuffThree = false;

        public override void ResetEffects()
        {
            CoreDebuffOne = false;
            CoreDebuffTwo = false;
            CoreDebuffThree = false;
        }

        public override void UpdateDead()
        {
            CoreDebuffOne = false;
            CoreDebuffTwo = false;
            CoreDebuffThree = false;
        }

        //public override void PreUpdateMovement()
        //{
            
        //}


        //public override void UpdateBiomes()
        //{
            
        //}

        public override void PostUpdateEquips()
        {
            Point center = player.Center.ToTileCoordinates();
            if (center.Y >= Main.maxTilesY - 200 && center.Y < Main.maxTilesY - 99)
            {
                player.AddBuff(mod.BuffType("CoreDebuffOne"), -1, false);
            }
            if (center.Y >= Main.maxTilesY - 100 && center.Y < Main.maxTilesY - 51)
            {
                player.AddBuff(mod.BuffType("CoreDebuffTwo"), -1, false);
            }
            if (center.Y >= Main.maxTilesY - 50)
            {
                player.AddBuff(mod.BuffType("CoreDebuffThree"), -1, false);
                //player.AddBuff(BuffID.Blackout, -1, false);
                CoreDebuffThree = true;
            }
        }


        public override void PostUpdate()
        {
            if (player.controlJump)
            {
                if (CoreDebuffThree)
                {
                    player.jump = Player.jumpHeight * 0;
                    player.velocity.Y = 0;
                }
            }
        }
            //public override void PreUpdateBuffs()
            //{
            //    if(player.lastTileRangeY > Main.maxTilesY - 200)
            //    {

            //    }
            //}
        }
}
