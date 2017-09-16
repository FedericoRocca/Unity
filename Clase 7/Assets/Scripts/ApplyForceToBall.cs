using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForceToBall : MonoBehaviour {

    private Rigidbody MyRigidBody;
    public int Force = 0;

	// Use this for initialization
	void Start () {
        MyRigidBody = GetComponent<Rigidbody>();
        MyRigidBody.AddForce(Vector3.forward * Force);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
