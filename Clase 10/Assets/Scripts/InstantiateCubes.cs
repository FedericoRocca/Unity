using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour {

	public GameObject CubePrefab;

	// Use this for initialization
	void Start () {
		
        int CantInstantiated = 0;

		while( CantInstantiated < 10 )
		{

            Instantiate(CubePrefab, 
			new Vector3( Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)), 
			Quaternion.identity, 
			transform);

			BroadcastMessage("AddRandomForce");

			CantInstantiated++;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
