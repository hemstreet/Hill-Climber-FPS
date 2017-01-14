using UnityEngine;

public class Enemy : MonoBehaviour {

	public float Health = 10f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void TakeDamage(int amount = 1)
	{
		Health -= amount;

		if (Health <= 0) {
			Destroy(gameObject);
		}
	}
}
