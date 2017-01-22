using System;
using Player;
using UnityEngine;

namespace Score
{
    public class Scoreboard {
        void UpdateScore(float score)
        {
            Debug.Log(String.Format("Updating score {0} to {1}", PlayerVariables.username, score));
        }
    }
}

