using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform PlayerPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Camera.main.transform.position = new Vector3( PlayerPosition.transform.position.x, 0, -10 );
	}
}
