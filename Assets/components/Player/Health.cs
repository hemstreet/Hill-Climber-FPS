using System;
using UnityEngine;

namespace Player
{
    public static class Health
    {

        // sending a positive or negative number to influence health
        public static void UpdateHealth(float value)
        {

            PlayerVariables.health += value;

            if (PlayerVariables.health < 0)
            {
                Debug.Log(String.Format("{0} died", PlayerVariables.username));
            }
        }
    }
}