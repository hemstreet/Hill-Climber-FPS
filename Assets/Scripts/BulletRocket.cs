using UnityEngine;

public class BulletRocket : MonoBehaviour {

	public GameObject BulletPrefab;
	public float BulletImpulse = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) 
		{
			Fire ();
		}
	}

	void Fire() {
		Camera cam = Camera.main;

		Transform cameraTransform = cam.transform;
		Vector3 cameraForward = cameraTransform.forward;

		GameObject bullet = Instantiate(BulletPrefab, cameraTransform.position + cameraForward, cameraTransform.rotation);
		bullet.GetComponent<Rigidbody>().AddForce(cameraForward * BulletImpulse, ForceMode.Impulse);
	}
}
