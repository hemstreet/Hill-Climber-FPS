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

            Camera.main.enabled = false;

            foreach (Behaviour script in componentsToDisable)
            {
                Destroy(script);
            }
        }
    }
}