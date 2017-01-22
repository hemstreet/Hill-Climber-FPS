using Player;
using UnityEngine;

namespace Items
{
    public class Helmet : MonoBehaviour
    {

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.CompareTag("Player"))
            {
                // update variables
                Pickup();
                Destroy(gameObject);
            }
        }

        void Pickup()
        {
            Health.UpdateHealth(-10);
            Debug.Log("Item Picked up");
        }
    }
}
