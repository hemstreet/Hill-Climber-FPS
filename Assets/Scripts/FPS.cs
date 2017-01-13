using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour {

	public GameObject bullet_prefab;

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
		Instantiate(bullet_prefab, this.transform.position, this.transform.rotation);
	}
}
