using UnityEngine;
using UnityEngine.Networking;

public class BulletRayNetwork : NetworkBehaviour {
	public float Cooldown = 0.2f;
	public float Range = 100.0f;
	public GameObject DebrisPrefab;

    private float _cooldownRemaining = 0;
	
    // Use this for initialization
    void Start()
    {
        if (!isLocalPlayer)
        {
            Destroy(this);
            return;
        }
    }

    // Update is called once per frame
	void Update ()
	{
	    _cooldownRemaining -= Time.deltaTime;

	    if (!Input.GetMouseButton(0) || !(_cooldownRemaining <= 0)) return;

	    _cooldownRemaining = Cooldown;
			
	    Transform transform = Camera.main.transform;
	    Ray ray = new Ray(transform.position, transform.forward);
	    RaycastHit hitInfo;

	    if (!Physics.Raycast(ray, out hitInfo, Range)) return;

	    Vector3 hitPoint = hitInfo.point;

	    if ( DebrisPrefab != null)
	    {
	        Instantiate(DebrisPrefab, hitPoint, Quaternion.identity);
	    }

	    // @TODO make this tag handle "hittable" objects and call a generic Hit method.
	    // any gameObjects w/ this flag need to implement this method ( as an interface? )
	    if (hitInfo.transform.gameObject.CompareTag("Enemy"))
	    {
	        // hitInfo.collider.gameObject.GetType()
	        Debug.Log("Hit Enemny");
	        Enemy enemy = hitInfo.collider.gameObject.GetComponent<Enemy>();
            enemy.Hit();
	    }

	    // Instantiate(debrisPrefab, hitPoint, hitInfo.normal)
	    // Instantiate(debrisPrefab, hitPoint, Quaternion.identity)
	}
}
