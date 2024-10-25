using Adlibirt.Classes;
using UnityEngine;
using static Adlibirt.Menu.Main;

namespace Adlibirt.Menu
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient { isRainbow = false };
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(Color.black) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(Color.red) } // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.red, // Disabled
            Color.black // Enabled
        };

        public static Font currentFont = Font.CreateDynamicFontFromOSFont("Comic Sans MS", 24);

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
