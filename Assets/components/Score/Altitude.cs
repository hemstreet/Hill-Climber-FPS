using UnityEngine;
using UnityEngine.UI;
using Player;

namespace Score
{
    public class Altitude : MonoBehaviour
    {
        public Text label;
        public FirstPersonController player;
        void Start () {
            Text label = gameObject.GetComponent<Text>();
            player = gameObject.GetComponentInParent<FirstPersonController>();

            label.text = "Altitude:";
        }

        void Update ()
        {
            int altitude = (int) player.transform.localPosition.y;
            label.text = altitude.ToString();
        }
    }
}