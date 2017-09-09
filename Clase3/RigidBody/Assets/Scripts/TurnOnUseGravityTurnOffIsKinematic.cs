using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnUseGravityTurnOffIsKinematic : MonoBehaviour {

    private Rigidbody MyRigidBody;

    // Use this for initialization
    void Awake()
    {
        MyRigidBody = transform.GetComponent<Rigidbody>();
        MyRigidBody.useGravity = true;
        MyRigidBody.isKinematic = false;
        MyRigidBody.constraints = RigidbodyConstraints.FreezePositionY;
        //MyRigidBody.constraints = RigidbodyConstraints.FreezeRotationY;
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
