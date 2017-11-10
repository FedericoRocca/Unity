using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour {

    public GameObject CubePrefab;

	// Use this for initialization
	void Start () {

        Transform[] Positions = GetComponentsInChildren<Transform>();

		for( int i = 0; i < Positions.Length; i++ )
        {
            if( Positions[i].tag.Equals("Floor") || Positions[i].tag.Equals("Wall"))
            {
                Instantiate(CubePrefab, Positions[i].transform.position, Positions[i].transform.rotation, Positions[i]);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
