using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	//ruch przeciwnika

	void Start () {
		
	}
    public float speed = 40f;
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);

        /*void OnTriggerEnter2D(Collider2D hitinfo)
        {
            Debug.Log(hitinfo.name);
            Destroy(gameObject);
        }*/
	}
}
