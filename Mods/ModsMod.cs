using System;
using GorillaLocomotion;
using static Adlibirt.Menu.Main;
using UnityEngine;

namespace Adlibirt.Mods
{
    internal class ModsMod
    {
        public static void FreezePlayerInMenu()
        {
            if (menu != null)
            {
                if (closePosition == Vector3.zero)
                {
                    closePosition = GorillaTagger.Instance.rigidbody.transform.position;
                }
                else
                {
                    GorillaTagger.Instance.rigidbody.transform.position = closePosition;
                }
                Player.Instance.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            }
            else
            {
                closePosition = Vector3.zero;
            }
        }
        public static void SpeedBoostMod()
        {
            Player.Instance.maxJumpSpeed = 9f;
            Player.Instance.jumpMultiplier = 9f;
        }
        public static void DisableNetworkTriggersMod()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(false);
        }
        public static void EnableNetworkTriggersMod()
        {
            GameObject.Find("Environment Objects/TriggerZones_Prefab/JoinRoomTriggers_Prefab").SetActive(true);
        }
        public static void KillYourSelfMod()
        {
            Application.Quit();
        }
        public static void InstantTapsMod()
        {
            GorillaTagger.Instance.tapCoolDown = 0f;
        }
        public static void InstantTapsOffMod()
        {
            GorillaTagger.Instance.tapCoolDown = 0.1f;
        }
        public static void TurnOffBugMod()
        {
            GameObject.Find("Floating Bug Holdable").SetActive(false);
        }
        public static void LongArmsMod()
        {
            Player.Instance.scale = 1.2f;
        }
        public static void FlyMod()
        {
            bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
            if (rightControllerPrimaryButton)
            {
                Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void ZeroGravityMod()
        {
            Player.Instance.GetComponent<Rigidbody>().velocity -= Vector3.down * 9.81f * Time.deltaTime;
        }
    }
}
