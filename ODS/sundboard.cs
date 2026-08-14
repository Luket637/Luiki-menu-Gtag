using UnityEngine;

namespace LuikiModMenu.Mods
{
    public static class Soundboard
    {
        public static AudioSource Source;
        public static AudioClip[] Sounds;

        public static void Play(int index)
        {
            if (Source == null)
            {
                Debug.LogWarning(
                    "[Luiki] No AudioSource assigned."
                );
                return;
            }

            if (Sounds == null ||
                index < 0 ||
                index >= Sounds.Length)
            {
                Debug.LogWarning(
                    "[Luiki] Invalid sound slot."
                );
                return;
            }

            if (Sounds[index] == null)
                return;

            Source.clip = Sounds[index];
            Source.Play();
        }

        public static void Stop()
        {
            if (Source != null)
                Source.Stop();
        }
    }
}
