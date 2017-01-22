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
            Debug.Log("Item Picked up");
        }
    }
}
