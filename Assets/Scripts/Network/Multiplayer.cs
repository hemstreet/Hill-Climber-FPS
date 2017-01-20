using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

namespace Network
{
    public class Multiplayer : NetworkBehaviour
    {
        [SerializeField]
        public Behaviour[] componentsToDisable;
        void Start ()
        {
            if (!isLocalPlayer)
            {
                for (int i = 0; i < componentsToDisable.Length; i++)
                {
                    componentsToDisable[i].enabled = false;
                }
            }
        }

    }
}