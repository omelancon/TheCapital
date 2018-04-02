using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using UnityEngine;
using RimWorld.Planet;
using Verse;

namespace TheCapital.WorldObjects
{
    public class Downtown: CapitalWorldObject
    {
        public override MapGeneratorDef MapGeneratorDef => DefDatabase<MapGeneratorDef>.GetNamed("TheCapitalMapGenerator");
    }
}
