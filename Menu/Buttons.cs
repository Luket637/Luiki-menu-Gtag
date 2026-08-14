using UnityEngine;

namespace LuikiModMenu.Menu
{
    public static class Buttons
    {
        public static void Speed()
        {
            Mods.MovementMods.ToggleSpeed();
        }

        public static void Fly()
        {
            Mods.MovementMods.ToggleFly();
        }

        public static void NoGravity()
        {
            Mods.MovementMods.ToggleNoGravity();
        }

        public static void JumpBoost()
        {
            Mods.MovementMods.ToggleJumpBoost();
        }

        public static void LongArms()
        {
            Mods.MovementMods.ToggleLongArms();
        }

        public static void Platforms()
        {
            Mods.MovementMods.TogglePlatforms();
        }

        public static void Invisible()
        {
            Mods.MovementMods.ToggleInvisible();
        }

        public static void GhostMonkey()
        {
            Mods.MovementMods.ToggleGhostMonkey();
        }

        public static void ResetMovement()
        {
            Mods.MovementMods.Reset();
        }

        public static void ReverseCard()
        {
            Debug.Log(
                "[Luiki] Reverse Card activated."
            );
        }

        public static void Disconnect()
        {
            Debug.Log(
                "[Luiki] Disconnect requested."
            );
        }

        public static void ResetSafety()
        {
            Mods.SafetyMods.Reset();
        }

        public static void PlaySound(int index)
        {
            Mods.Soundboard.Play(index);
        }

        public static void StopSound()
        {
            Mods.Soundboard.Stop();
        }
    
        public static void KickGun()
        {
        Mods.OverpoweredMods.KickGun();
        }

        public static void KickAll()
        {
            Mods.OverpoweredMods.KickAll();
        }

        public static void CrashGun()
        {
            Mods.OverpoweredMods.CrashGun();
        }
        
        public static void CrashAll()
        {
            Mods.OverpoweredMods.CrashAll();
        }
        
        public static void BanGun()
        {
            Mods.OverpoweredMods.BanGun();
        }
        
        public static void ReverseCard()
        {
            Mods.OverpoweredMods.ReverseCard();
        }
    }
}
