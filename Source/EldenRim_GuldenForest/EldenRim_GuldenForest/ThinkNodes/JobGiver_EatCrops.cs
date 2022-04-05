using RimWorld;
using System;
using Verse;
using Verse.AI;

namespace EldenRim_GuldenForest
{
    class JobGiver_EatCrops : ThinkNode_JobGiver
    {
		protected override Job TryGiveJob(Pawn pawn)
		{
			if (pawn.Downed)
			{
				return null;
			}
			float radius = EldenRim_GuldenForest_ModSettings.Range_CropEating;
			bool validator(Thing t) => t is Plant p && p.sown && p.IngestibleNow && pawn.RaceProps.CanEverEat(p) && pawn.CanReserve(p, 1, -1, null, false);
			Thing plant = GenClosest.ClosestThingReachable(pawn.Position, pawn.Map, ThingRequest.ForGroup(ThingRequestGroup.Plant), PathEndMode.OnCell, TraverseParms.For(pawn, Danger.Deadly, TraverseMode.ByPawn, false), radius, validator, null, 0, -1, false, RegionType.Set_Passable, false);
			if (plant == null)
			{
				return null;
			}
			return JobMaker.MakeJob(RimWorld.JobDefOf.Ingest, plant);
		}
	}
}
