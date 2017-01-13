using UnityEngine;

public class Enemy : MonoBehaviour {

	public float health = 10f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TakeDamage(int amount = 1) 
	{
		health -= amount;

		if (health <= 0) {
			Destroy(gameObject);
		}
	}
}
