using UnityEngine;

public class Enemy : MonoBehaviour {

	public float Health = 10f;
    private PlayerHUD _playerHud;

    public Enemy(PlayerHUD hud = null)
    {
        if (hud)
        {
            _playerHud = hud;
        }
    }
	// Use this for initialization
	void Start () {
	}
	
    // Update is called once per frame
	void Update () {
		
	}
    public void TakeDamage(int amount = 1)
	{
		Health -= amount;

	    if (_playerHud)
	    {
	        _playerHud.UpdateHealth(Health);
	    }

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
