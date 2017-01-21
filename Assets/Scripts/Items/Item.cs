using UnityEngine;

public class Item : MonoBehaviour {
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            // PlayerVariables.health += 2;
            // update variables
            Destroy(gameObject);
        }
    }
}
