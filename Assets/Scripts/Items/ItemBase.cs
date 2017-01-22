using UnityEngine;

namespace Items
{
    public class ItemBase : MonoBehaviour
    {

        private void OnTriggerEnter(Collider collider)
        {

            if (collider.gameObject.tag == "Player")
            {
                Debug.Log("Item Base pickup");
//                gameObject.Pickup();

                // update variables
                Destroy(gameObject);
            }
        }
    }
}
