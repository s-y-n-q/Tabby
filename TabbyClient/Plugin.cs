using BepInEx;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TabbyClient
{
    [BepInPlugin("synq.gorilla.tabby", "Tabby Client", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("synq.gorilla.tabby");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            Logger.LogInfo("Initialized Tabby Client!");
        }
    }

    // exp
    /*
    [HarmonyPatch(typeof(CharacterMovement), "CheckFallDamage")]
    public class FallDamagePatch
    {
        private static bool Prefix()
        {
            UI.NewDebugNotif("Patched CharacterMovement.checkfalldamage");
            return !Self.NFD;
        }
    }*/
}
