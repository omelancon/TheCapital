using System;
using System.Collections.Generic;
using RimWorld;
using RimWorld.BaseGen;
using RimWorld.Planet;
using UnityEngine;
using Verse;

namespace TheCapital.MapGenSteps
{
    public class GenStep_CapitalRoadNetwork : GenStep
    {   
        public override void Generate(Map map)
        {
            TerrainDef roadTerrain = BaseGenUtility.RegionalRockTerrainDef(map.Tile, true);
            
            foreach (var cell in map.AllCells)
            {
                if (cell.Walkable(map))
                {
                    //map.terrainGrid.SetTerrain(cell, roadTerrain);
                }
            }
        }

        private IEnumerable<IntVec3> GetRoadCells(Map map)
        {
            var RoadCells = new List<IntVec3>();

            foreach (var cell in map.AllCells)
            {
                RoadCells.Add(cell);
            }
            
            return RoadCells;
        }
    }
}