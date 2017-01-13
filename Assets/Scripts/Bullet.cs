using UnityEngine;

public class Bullet : MonoBehaviour {

	public GameObject flame_prefab;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter(Collision collision) 
	{
		string collisionTag = collision.gameObject.tag;

		if (collisionTag == "Enemy") 
		{
			// For old dropping in flame animation and what not
			// collision.gameObject.tag = "Untagged";
			// Instantiate(flame_prefab, collision.transform.position, collision.transform.rotation);
			Destroy(gameObject);

			// @TODO Use take damage, to kill off enemy
			// collision.gameObject.TakeDamage();	
		}
	}
}
