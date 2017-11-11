using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour {

    public GameObject CubePrefab;
    public GameObject MinPos;
    public GameObject MaxPos;

	// Use this for initialization
	void Start () {

        Transform[] Positions = GetComponentsInChildren<Transform>();
        /*
		for( int i = 0; i < Positions.Length; i++ )
        {
            if( Positions[i].tag.Equals("Floor") || Positions[i].tag.Equals("Wall"))
            {
                Instantiate(CubePrefab, Positions[i].transform.position, Positions[i].transform.rotation, Positions[i]);
            }
        }*/
        Vector2 TempPos;
        int TempX = (int)MinPos.transform.position.x;
        TempPos.y = MinPos.transform.position.y;
        while( MinPos.transform.position.x <= MaxPos.transform.position.x )
        {
            TempPos.x = MinPos.transform.position.x + TempX;
            Instantiate( CubePrefab, TempPos, MinPos.transform.rotation );
            TempX++;
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
