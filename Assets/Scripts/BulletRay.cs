using System.Collections;
using System.Collections.Generic;
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

		Debug.Log(cooldownRemaining);
		if (Input.GetMouseButton(0) && cooldownRemaining <= 0) 
		{
			cooldownRemaining = cooldown;
			
			Transform transform = Camera.main.transform;
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hitInfo;

			if (Physics.Raycast(ray, out hitInfo, range)) 
			{
				// hitInfo.collider
				Vector3 hitPoint = hitInfo.point;

				if ( debrisPrefab != null) 
				{
					Instantiate(debrisPrefab, hitPoint, Quaternion.identity);
				}
				// Instantiate(debrisPrefab, hitPoint, hitInfo.normal)
				// Instantiate(debrisPrefab, hitPoint, Quaternion.identity)
			}
		}
	}
}
