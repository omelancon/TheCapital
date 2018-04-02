using Verse;
using RimWorld.BaseGen;

namespace TheCapital.MapGenSteps
{
    public class GenStep_CapitalTerrain : GenStep
    {   
        public override void Generate(Map map)
        {

            TerrainDef baseTerrain = BaseGenUtility.RegionalRockTerrainDef(map.Tile, false);
                
            foreach (var cell in map.AllCells)
            {
                map.terrainGrid.SetTerrain(cell, baseTerrain);
            }
        }
    }
}