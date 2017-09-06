using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyForce : MonoBehaviour {

    private Rigidbody MyRigidBody;
    public uint Impulse;

    // Use this for initialization
    void Start() {

        MyRigidBody = transform.GetComponent<Rigidbody>();
        MyRigidBody.AddForce( new Vector3( Random.Range(0, 2) , Random.Range(0, 2), 0) * 1000 );

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
