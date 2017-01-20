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

            if (isLocalPlayer) return;

            foreach (Behaviour script in componentsToDisable)
            {
                script.enabled = false;
            }
        }

    }
}