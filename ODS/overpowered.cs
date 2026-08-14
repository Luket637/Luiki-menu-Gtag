using UnityEngine;

namespace LuikiModMenu.Mods
{
    public static class OverpoweredMods
    {
        // These are UI/test actions only.
        // They do not kick, crash, or ban public players.

        public static void KickGun()
        {
            Debug.Log("[Luiki] Kick Gun - private/test only.");
        }

        public static void KickAll()
        {
            Debug.Log("[Luiki] Kick All - private/test only.");
        }

        public static void CrashGun()
        {
            Debug.Log("[Luiki] Crash Gun - private/test only.");
        }

        public static void CrashAll()
        {
            Debug.Log("[Luiki] Crash All - private/test only.");
        }

        public static void BanGun()
        {
            Debug.Log("[Luiki] Ban Gun - private/test only.");
        }

        public static void ReverseCard()
        {
            Debug.Log("[Luiki] REVERSE CARD!");
        }
    }
}
