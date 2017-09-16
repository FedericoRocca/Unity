using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBallInPlataform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision ACollision)
    {
        ACollision.rigidbody.velocity = Vector3.zero ;
        ACollision.rigidbody.angularVelocity= Vector3.zero;
    }

}
