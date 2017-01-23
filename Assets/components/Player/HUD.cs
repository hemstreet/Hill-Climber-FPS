using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class HUD : MonoBehaviour
    {
        public Text health;
        public Text altitude;
        public Text timer;

        void Update ()
        {
            altitude.text = string.Format("Altitude: {0}", PlayerVariables.altitude.ToString()) ;
            health.text = string.Format("Health: {0}", PlayerVariables.health.ToString()) ;

            UpdateTimer();
        }

        void UpdateTimer()
        {
            int minutes = Mathf.FloorToInt(GlobalVariables.timer / 60F);
            int seconds = Mathf.FloorToInt(GlobalVariables.timer - minutes * 60);

            timer.text = string.Format("Time: {0:0}:{1:00}", minutes, seconds);
        }
    }
}