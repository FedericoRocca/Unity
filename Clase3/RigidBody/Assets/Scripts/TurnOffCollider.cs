using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCollider : MonoBehaviour {

    private Collider MyCollider;

	// Use this for initialization
	void Start () {
        MyCollider = transform.GetComponent<Collider>();
        MyCollider.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
