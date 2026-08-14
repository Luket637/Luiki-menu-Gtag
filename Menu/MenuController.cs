using UnityEngine;
using UnityEngine.UI;

namespace LuikiModMenu.Menu
{
    public class MenuController : MonoBehaviour
    {
        private GameObject menu;
        private GameObject content;

        private readonly Color blue =
            new Color(0.05f, 0.35f, 1f);

        private readonly Color black =
            Color.black;

        private readonly Color white =
            Color.white;

        private void Start()
        {
            CreateMenu();
        }

        private void Update()
        {
            // Toggle the menu with F1 while testing on PC.
            if (Input.GetKeyDown(KeyCode.F1))
            {
                if (menu != null)
                    menu.SetActive(!menu.activeSelf);
            }
        }

        private void CreateMenu()
        {
            GameObject canvasObject =
                new GameObject("LuikiCanvas");

            Canvas canvas =
                canvasObject.AddComponent<Canvas>();

            canvas.renderMode =
                RenderMode.WorldSpace;

            CanvasScaler scaler =
                canvasObject.AddComponent<CanvasScaler>();

            scaler.dynamicPixelsPerUnit = 10f;

            canvasObject.AddComponent<GraphicRaycaster>();

            menu =
                new GameObject("LuikiMenu");

            menu.transform.SetParent(
                canvasObject.transform,
                false
            );

            Image background =
                menu.AddComponent<Image>();

            background.color = blue;

            RectTransform menuRect =
                menu.GetComponent<RectTransform>();

            menuRect.sizeDelta =
                new Vector2(650f, 500f);

            CreateTitle();
            CreateMainTabs();

            ShowMovement();
        }

        private void CreateTitle()
        {
            CreateText(
                menu.transform,
                "LUIKI MOD MENU",
                30,
                new Vector2(0, 215)
            );
        }

        private void CreateMainTabs()
        {
            CreateButton(
                "MOVEMENT",
                new Vector2(-200, 165),
                ShowMovement
            );

            CreateButton(
                "OVERPOWERED",
                new Vector2(0, 165),
                ShowOverpowered
            );

            CreateButton(
                "SAFETY",
                new Vector2(200, 165),
                ShowSafety
            );

            CreateButton(
                "SOUNDBOARD",
                new Vector2(0, 115),
                ShowSoundboard
            );
        }

        private void ClearContent()
        {
            if (content == null)
                return;

            for (int i = content.transform.childCount - 1;
                 i >= 0;
                 i--)
            {
                Destroy(
                    content.transform.GetChild(i).gameObject
                );
            }
        }

        private void CreateContent()
        {
            if (content != null)
                return;

            content =
                new GameObject("Content");

            content.transform.SetParent(
                menu.transform,
                false
            );
        }

        // =========================
        // MOVEMENT
        // =========================

        private void ShowMovement()
        {
            CreateContent();
            ClearContent();

            CreateContentButton(
                "Speed",
                new Vector2(0, 75),
                Buttons.Speed
            );

            CreateContentButton(
                "Fly",
                new Vector2(0, 25),
                Buttons.Fly
            );

            CreateContentButton(
                "No Gravity",
                new Vector2(0, -25),
                Buttons.NoGravity
            );

            CreateContentButton(
                "Jump Boost",
                new Vector2(0, -75),
                Buttons.JumpBoost
            );

            CreateContentButton(
                "Long Arms",
                new Vector2(0, -125),
                Buttons.LongArms
            );

            CreateContentButton(
                "Platforms",
                new Vector2(0, -175),
                Buttons.Platforms
            );

            CreateContentButton(
                "Invisible",
                new Vector2(0, -225),
                Buttons.Invisible
            );

            CreateContentButton(
                "Ghost Monkey [B]",
                new Vector2(0, -275),
                Buttons.GhostMonkey
            );

            CreateContentButton(
                "Reset",
                new Vector2(0, -325),
                Buttons.ResetMovement
            );
        }

        // =========================
        // OVERPOWERED
        // =========================

        private void ShowOverpowered()
        {
            CreateContent();
            ClearContent();

            // These are displayed as private/local test actions.
            CreateContentButton(
                "Kick Gun",
                new Vector2(0, 75),
                Buttons.KickGun
            );

            CreateContentButton(
                "Kick All",
                new Vector2(0, 25),
                Buttons.KickAll
            );

            CreateContentButton(
                "Crash Gun",
                new Vector2(0, -25),
                Buttons.CrashGun
            );

            CreateContentButton(
                "Crash All",
                new Vector2(0, -75),
                Buttons.CrashAll
            );

            CreateContentButton(
                "Ban Gun",
                new Vector2(0, -125),
                Buttons.BanGun
            );

            CreateContentButton(
                "Reverse Card",
                new Vector2(0, -175),
                Buttons.ReverseCard
            );
        }

        // =========================
        // SAFETY
        // =========================

        private void ShowSafety()
        {
            CreateContent();
            ClearContent();

            CreateContentButton(
                "Anti-Report",
                new Vector2(0, 75),
                Buttons.ResetSafety
            );

            CreateContentButton(
                "Disconnect",
                new Vector2(0, 25),
                Buttons.Disconnect
            );

            CreateContentButton(
                "Hide Name",
                new Vector2(0, -25),
                Buttons.ResetSafety
            );

            CreateContentButton(
                "Reset Safety",
                new Vector2(0, -75),
                Buttons.ResetSafety
            );
        }

        // =========================
        // SOUNDBOARD
        // =========================

        private void ShowSoundboard()
        {
            CreateContent();
            ClearContent();

            CreateContentButton(
                "Sound 1",
                new Vector2(0, 75),
                () => Buttons.PlaySound(0)
            );

            CreateContentButton(
                "Sound 2",
                new Vector2(0, 25),
                () => Buttons.PlaySound(1)
            );

            CreateContentButton(
                "Sound 3",
                new Vector2(0, -25),
                () => Buttons.PlaySound(2)
            );

            CreateContentButton(
                "Sound 4",
                new Vector2(0, -75),
                () => Buttons.PlaySound(3)
            );

            CreateContentButton(
                "Sound 5",
                new Vector2(0, -125),
                () => Buttons.PlaySound(4)
            );

            CreateContentButton(
                "Stop Sound",
                new Vector2(0, -175),
                Buttons.StopSound
            );
        }

        // =========================
        // UI CREATION
        // =========================

        private void CreateContentButton(
            string text,
            Vector2 position,
            UnityEngine.Events.UnityAction action)
        {
            GameObject obj =
                new GameObject(text);

            obj.transform.SetParent(
                content.transform,
                false
            );

            Image image =
                obj.AddComponent<Image>();

            image.color = black;

            Button button =
                obj.AddComponent<Button>();

            button.onClick.AddListener(action);

            RectTransform rect =
                obj.GetComponent<RectTransform>();

            rect.sizeDelta =
                new Vector2(240f, 40f);

            rect.anchoredPosition =
                position;

            CreateText(
                obj.transform,
                text,
                17,
                Vector2.zero,
                true
            );
        }

        private void CreateButton(
            string text,
            Vector2 position,
            UnityEngine.Events.UnityAction action)
        {
            GameObject obj =
                new GameObject(text);

            obj.transform.SetParent(
                menu.transform,
                false
            );

            Image image =
                obj.AddComponent<Image>();

            image.color = black;

            Button button =
                obj.AddComponent<Button>();

            button.onClick.AddListener(action);

            RectTransform rect =
                obj.GetComponent<RectTransform>();

            rect.sizeDelta =
                new Vector2(180f, 40f);

            rect.anchoredPosition =
                position;

            CreateText(
                obj.transform,
                text,
                15,
                Vector2.zero,
                true
            );
        }

        private void CreateText(
            Transform parent,
            string text,
            int size,
            Vector2 position,
            bool stretch = false)
        {
            GameObject obj =
                new GameObject("Text");

            obj.transform.SetParent(
                parent,
                false
            );

            Text label =
                obj.AddComponent<Text>();

            label.text = text;
            label.fontSize = size;
            label.color = white;
            label.alignment =
                TextAnchor.MiddleCenter;

            label.font =
                Resources.GetBuiltinResource<Font>(
                    "LegacyRuntime.ttf"
                );

            RectTransform rect =
                obj.GetComponent<RectTransform>();

            if (stretch)
            {
                rect.anchorMin =
                    Vector2.zero;

                rect.anchorMax =
                    Vector2.one;

                rect.offsetMin =
                    Vector2.zero;

                rect.offsetMax =
                    Vector2.zero;
            }
            else
            {
                rect.sizeDelta =
                    new Vector2(600f, 60f);

                rect.anchoredPosition =
                    position;
            }
        }
    }
}
