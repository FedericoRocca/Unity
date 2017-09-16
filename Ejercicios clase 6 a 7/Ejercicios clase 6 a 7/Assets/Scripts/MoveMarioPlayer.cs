using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMarioPlayer : MonoBehaviour {

    public int Step = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if( Input.GetKey( KeyCode.RightArrow ) && transform.position.x >= 7 )
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * Step);
        }

	}
}
