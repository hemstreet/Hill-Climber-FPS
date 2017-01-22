using Player;
using UnityEngine;

namespace Items
{
    public class Helmet : ItemBase
    {

        public static string armor;
        public GameObject icon;

        void Pickup()
        {
            Debug.Log("Item Picked up");
            PlayerVariables.inventory.AddGameObjectToInventory(gameObject);

        }
        // Use this for initialization
        void Start () {

        }

        // Update is called once per frame
        void Update () {

        }
    }

}
