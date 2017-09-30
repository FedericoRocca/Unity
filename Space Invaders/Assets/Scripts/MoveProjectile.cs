using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 10, ForceMode.Force);
	}

}
