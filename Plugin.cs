using BepInEx;
using UnityEngine;

namespace LuikiModMenu
{
    [BepInPlugin(
        PluginInfo.GUID,
        PluginInfo.Name,
        PluginInfo.Version
    )]
    public class Plugin : BaseUnityPlugin
    {
        public static Plugin Instance;

        private GameObject menuObject;

        private void Awake()
        {
            Instance = this;

            Logger.LogInfo(
                "Luiki Mod Menu loaded!"
            );

            CreateMenu();
        }

        private void CreateMenu()
        {
            menuObject = new GameObject(
                "Luiki Mod Menu"
            );

            menuObject.AddComponent<Menu.MenuController>();
            DontDestroyOnLoad(menuObject);
        }
    }
}
