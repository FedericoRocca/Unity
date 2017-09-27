using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMisile : MonoBehaviour {

	private Transform PlayerPos;

	// Use this for initialization
	void Start () {
		PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 10);
	}

	void LateUpdate()
	{
		if( PlayerPos != null )
		{
			transform.LookAt(PlayerPos);
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		if( collision.gameObject.CompareTag("Player") )
		{
			Destroy(this.gameObject);
			Destroy(collision.gameObject);
		}
		else if( collision.gameObject.CompareTag("Floor") )
		{
			Destroy(this.gameObject);
		}
	}

}