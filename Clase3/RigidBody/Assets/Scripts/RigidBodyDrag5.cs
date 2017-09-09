using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyDrag5 : MonoBehaviour {

    private Rigidbody MyRigidBody;

    private void Awake()
    {
        MyRigidBody = transform.GetComponent<Rigidbody>();
        MyRigidBody.drag = 5;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
