using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffUseGravity : MonoBehaviour {

    private Rigidbody MyRigidBody;

    private void Awake()
    {
        MyRigidBody = transform.GetComponent<Rigidbody>();
        MyRigidBody.useGravity = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
