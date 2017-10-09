using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float Step = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate()
	{
		
		if( Input.GetKey( KeyCode.RightArrow ) && gameObject.GetComponent<Transform>().position.x <= 7.12f )
		{
			gameObject.GetComponent<Transform>().Translate(Vector3.right * Step * Time.deltaTime);
		} else if( Input.GetKey( KeyCode.LeftArrow ) && gameObject.GetComponent<Transform>().position.x >= -7.12f )
		{
			gameObject.GetComponent<Transform>().Translate(Vector3.left * Step * Time.deltaTime);
		}

	}
}
