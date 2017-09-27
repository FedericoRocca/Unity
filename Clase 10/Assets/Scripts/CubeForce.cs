using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForce : MonoBehaviour {

	public float ForceToApply;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void AddRandomForce()
	{
		gameObject.GetComponent<Rigidbody>().AddForce( new Vector3( Random.Range(-10, 10),
		                                                            Random.Range(-10, 10),
																	Random.Range(-10, 10)) * ForceToApply );
	}

}
