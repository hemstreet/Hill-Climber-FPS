using UnityEngine;

namespace Scenario
{
    public class TeamDeathMatch : MonoBehaviour
    {
        [Header("Options")]
        public float timeLimit;
        public string levelKey = "Mountain";

        void Setup()
        {
            GlobalVariables.timer = 0;
        }

        void Update () {
            GlobalVariables.timer += Time.deltaTime;

            if (GlobalVariables.timer >= timeLimit) {
                Application.LoadLevel(levelKey);
            }
        }
    }
}