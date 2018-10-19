using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject bullet;

	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{  
			Destroy(Instantiate(bullet, transform.position, transform.rotation), 2); 
		}
	}
}
