namespace LuikiModMenu.Mods
{
    public static class SafetyMods
    {
        public static bool AntiReport;
        public static bool HideName;

        public static void ToggleAntiReport()
        {
            AntiReport = !AntiReport;
        }

        public static void ToggleHideName()
        {
            HideName = !HideName;
        }

        public static void Reset()
        {
            AntiReport = false;
            HideName = false;
        }
    }
}
