using Adlibirt.Classes;
using Adlibirt.Mods;
using static Adlibirt.Menu.Settings;

namespace Adlibirt.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement Mods", method =() => SettingsMods.MovementMods(), isTogglable = false, toolTip = "Opens the list of mods the menu offers."},
                new ButtonInfo { buttonText = "Room Mods", method =() => SettingsMods.RoomMods(), isTogglable = false, toolTip = "Opens the list of mods the menu offers."},
                new ButtonInfo { buttonText = "Other Mods", method =() => SettingsMods.OtherMods(), isTogglable = false, toolTip = "Opens the list of mods the menu offers."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] { // Movement Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Speedboost", method =() => ModsMod.SpeedBoostMod(), toolTip = "Gives a speed boost."},
                new ButtonInfo { buttonText = "Instant Taps On", enableMethod =() => ModsMod.InstantTapsMod(), disableMethod =() => ModsMod.InstantTapsOffMod(), toolTip = "Sets taps to 0."},
                new ButtonInfo { buttonText = "Fly [<color=green>A</color>]", method =() => ModsMod.FlyMod(), toolTip = "Allows you to fly with [A]."},
                new ButtonInfo { buttonText = "Long Arms", method =() => ModsMod.LongArmsMod(), toolTip = "Gives you the max arm length."},
                new ButtonInfo { buttonText = "Zero Gravity", method =() => ModsMod.ZeroGravityMod(), toolTip = "Removes the gravity."},
            },

            new ButtonInfo[] { // Room Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Disable Lobby Join", enableMethod =() => ModsMod.DisableNetworkTriggersMod(), disableMethod =() => ModsMod.EnableNetworkTriggersMod(), toolTip = "You can't join rooms now."},
                new ButtonInfo { buttonText = "Turn Off Flying Bugs", method =() => ModsMod.TurnOffBugMod(), toolTip = "Turns off the bugs in forest. (atleast one of them idk man)"},
            },

            new ButtonInfo[] { // Other Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Listen to LowTierGod's Speech", method =() => ModsMod.KillYourSelfMod(), toolTip = "LLLLLLLL"},
            },
        };
    }
}
