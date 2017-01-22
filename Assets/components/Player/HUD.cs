using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Player
{
    public class HUD : MonoBehaviour
    {
        public Text health;
        public Text altitude;

        void Update ()
        {
            altitude.text = String.Format("Altitude: {0}", PlayerVariables.altitude.ToString()) ;
            health.text = String.Format("Health: {0}", PlayerVariables.health.ToString()) ;
        }
    }
}