using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarioPlayer : MonoBehaviour {

    public int Step = 5;
    private Rigidbody MyRigidBody;

	// Use this for initialization
	void Start () {

        MyRigidBody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
        if( Input.GetKey( KeyCode.RightArrow ) && transform.position.x <= 7 )
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * Step);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -7)
        {
            transform.position = transform.position + (Vector3.left * Time.deltaTime * Step);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            MyRigidBody.AddForce(Vector3.up * 200);
        }

    }
}
