using Verse;

namespace EldenRim_GuldenForest
{
    class EldenRim_GuldenForest_ModSettings : ModSettings
    {
        private static EldenRim_GuldenForest_ModSettings _instance;

        public static bool Enable_CropEating
        {
            get
            {
                return _instance.EldenRim_GuldenForest_Enable_CropEating;
            }
        }

        public static float Range_CropEating
        {
            get
            {
                return _instance.EldenRim_GuldenForest_Range_CropEating;
            }
        }

        public bool EldenRim_GuldenForest_Enable_CropEating = true;
        public float EldenRim_GuldenForest_Range_CropEating = 50f;

        public EldenRim_GuldenForest_ModSettings()
        {
            _instance = this;
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref EldenRim_GuldenForest_Enable_CropEating, "EldenRim_GuldenForest_Enable_CropEating", true);
            Scribe_Values.Look(ref EldenRim_GuldenForest_Range_CropEating, "EldenRim_GuldenForest_Range_CropEating", 50f);
        }
    }
}
