using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUpSize : MonoBehaviour {

    private SphereCollider Mycollider;

	// Use this for initialization
	void Start () {
        Mycollider = transform.GetComponent<SphereCollider>();
        Mycollider.radius = Mycollider.radius * 2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
