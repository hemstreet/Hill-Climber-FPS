using UnityEngine;

public class EnemyNetwork : MonoBehaviour {

	public float Health = 10f;
	
	// Use this for initialization
	void Start () {
	}

    public void TakeDamage(int amount = 1)
	{
		Health -= amount;

		if (Health <= 0) {
			Destroy(gameObject);
		}
	}

    // Hit an object, we can detect where they were hit ( helmet / body ) and adjust damage from there
    public void Hit()
    {
        TakeDamage(1);
    }
}
