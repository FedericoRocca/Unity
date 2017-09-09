using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnUseGravityAndIsKinematic : MonoBehaviour {

    private Rigidbody MyRigidBody;

    private void Awake()
    {
        MyRigidBody = transform.GetComponent<Rigidbody>();
        MyRigidBody.useGravity = true;
        MyRigidBody.isKinematic = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
