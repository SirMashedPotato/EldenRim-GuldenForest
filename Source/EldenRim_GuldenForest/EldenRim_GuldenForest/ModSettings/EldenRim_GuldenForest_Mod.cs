using UnityEngine;
using Verse;
using System;

namespace EldenRim_GuldenForest
{
    class EldenRim_GuldenForest_Mod : Mod
    {
        EldenRim_GuldenForest_ModSettings settings;

        public EldenRim_GuldenForest_Mod(ModContentPack contentPack) : base(contentPack)
        {
            this.settings = GetSettings<EldenRim_GuldenForest_ModSettings>();
        }

        public override string SettingsCategory() => "EldenRim_GuldenForest_ModName".Translate();

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            listing_Standard.Gap();

            listing_Standard.CheckboxLabeled("EldenRim_GuldenForest_Enable_CropEating".Translate(), ref settings.EldenRim_GuldenForest_Enable_CropEating);
            listing_Standard.Gap();

            listing_Standard.Label("EldenRim_GuldenForest_Range_CropEating".Translate() + " (" + settings.EldenRim_GuldenForest_Range_CropEating + ")");
            settings.EldenRim_GuldenForest_Range_CropEating = (int)Math.Round(listing_Standard.Slider(settings.EldenRim_GuldenForest_Range_CropEating, 1, 100));
            listing_Standard.Gap();

            listing_Standard.GapLine();
            listing_Standard.Gap();

            listing_Standard.End();
            base.DoSettingsWindowContents(inRect);
        }
    }
}
