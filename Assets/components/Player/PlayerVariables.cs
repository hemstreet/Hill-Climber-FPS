using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public static class PlayerVariables
    {
        public static string username;
        public static float health;
        public static float ammunition;
        public static Inventory inventory;
        public static Dictionary<string, GameObject> armor;
        public static Dictionary<string, GameObject> weapons;
    }
}