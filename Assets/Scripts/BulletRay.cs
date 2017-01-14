using UnityEngine;

public class BulletRay : MonoBehaviour {
	public float cooldown = 0.2f;
	public float range = 100.0f;
	float cooldownRemaining = 0;
	public GameObject debrisPrefab;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cooldownRemaining -= Time.deltaTime;

	    if (!Input.GetMouseButton(0) || !(cooldownRemaining <= 0)) return;
	    cooldownRemaining = cooldown;
			
	    Transform transform = Camera.main.transform;
	    Ray ray = new Ray(transform.position, transform.forward);
	    RaycastHit hitInfo;

	    //
	    if (!Physics.Raycast(ray, out hitInfo, range)) return;

	    // hitInfo.collider
	    Vector3 hitPoint = hitInfo.point;

	    if ( debrisPrefab != null)
	    {
	        Instantiate(debrisPrefab, hitPoint, Quaternion.identity);
	    }


	    if (hitInfo.transform.gameObject.tag  == "Enemy")
	    {

	        Enemy enemy = hitInfo.collider.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage();
	    }
	    // Instantiate(debrisPrefab, hitPoint, hitInfo.normal)
	    // Instantiate(debrisPrefab, hitPoint, Quaternion.identity)
	}
}
