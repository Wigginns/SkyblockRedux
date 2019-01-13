using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;


namespace SkyblockRedux
{
    public class SkyblockReduxWorld : ModWorld
    {
        /*A very rough initial override to learn how to modify world generation. Needs lots of work to make clean
        Needs lots of work to make clean and more consistent.*/
        //TODO: PROGRESS MESSAGES
        //TODO: RESOLVE BUG WITH GENERATION THAT FORCES YOU TO CREATE A NEW WORLD BEFORE YOU CAN GENERATE SOMETIMES
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {

            tasks.RemoveAll(x => x.Name != "Reset"  
                                 && x.Name != "Spawn Point"
                                 //&& x.Name != "Underworld"
                                 && x.Name != "Guide"
                                 && x.Name != "Final Cleanup");

            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Spawn Point"));

            tasks.Insert(genIndex + 1, new PassLegacy("Dirt Blob", delegate (GenerationProgress progress)
            {
                WorldGen.TileRunner(Main.spawnTileX, Main.spawnTileY + 5, 50, Main.rand.Next(1, 3), TileID.Dirt, true, 0f, 0f, true, true);
            }));

            tasks.Insert(genIndex + 2, new PassLegacy("Lavabottom", delegate (GenerationProgress progress)
            {
                
                for (int x = 0; x < Main.maxTilesX; x++)
                {
                    //Main.tile[deathTileX, Main.maxTilesY - 43].lava();
                    WorldGen.PlaceTile(x, Main.maxTilesY - 43, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 44, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 45, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 46, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 47, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 60, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 100, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 200, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 201, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 202, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 203, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 204, TileID.Ash);
                    //WorldGen.PlaceTile(x, Main.maxTilesY - 260, TileID.Ash);
                    WorldGen.PlaceTile(x, Main.maxTilesY - 300, TileID.Ash);
                }
                
            }));

        }
    }
}