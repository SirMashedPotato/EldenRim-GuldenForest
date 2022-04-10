using System;
using Verse;
using RimWorld;

namespace EldenRim_GuldenForest
{
	[DefOf]
	public static class ThingDefOf
	{

		static ThingDefOf()
		{
			DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
		}

		public static ThingDef Plant_GuldenAmbrosia;
	}
}
