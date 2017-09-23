using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMisiles : MonoBehaviour {
	public GameObject MisilePrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("InstantiateMisile", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InstantiateMisile()
	{
		Vector3 RandPos = new Vector3( Random.Range(-10, 10), 10, Random.Range(-10, 10));
		Instantiate( MisilePrefab, RandPos, Quaternion.identity );
	}

}
