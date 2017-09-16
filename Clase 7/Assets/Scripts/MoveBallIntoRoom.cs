using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallIntoRoom : MonoBehaviour {

    private Rigidbody MyRigidBody;
    public int MoveForce = 1;

	// Use this for initialization
	void Start () {
        MyRigidBody = GetComponent<Rigidbody>();
        MyRigidBody.AddForce( Vector3.forward * MoveForce);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
