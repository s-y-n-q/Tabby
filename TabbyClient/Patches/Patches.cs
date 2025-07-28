using GorillaNetworking;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbyClient.Patches
{
    [HarmonyPatch(typeof(PlayFabAuthenticator), "Awake")]
    public class FallDamagePatch
    {
        private static bool Prefix()
        {
            
        }
    }
}
