using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Health {

        // sending a positive or negative number to influence health
        void UpdateHealth(float value)
        {
            PlayerVariables.health += value;

            if (PlayerVariables.health < 0)
            {
                Debug.Log(String.Format("{0} died", PlayerVariables.username));
            }
        }
    }
}