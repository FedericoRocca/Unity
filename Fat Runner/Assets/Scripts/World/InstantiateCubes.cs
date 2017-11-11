using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour {

    public GameObject CubePrefab;
    public GameObject MinPos;
    public GameObject MaxPos;
    public int Height;

	// Use this for initialization
	void Start () {
        /*Transform[] Positions = GetComponentsInChildren<Transform>();

        for (int i = 0; i < Positions.Length; i++)
        {
            if (Positions[i].tag.Equals("Floor") || Positions[i].tag.Equals("Wall"))
            {
                Instantiate(CubePrefab, Positions[i].transform.position, Positions[i].transform.rotation, Positions[i]);
            }
        }*/
        Vector2 TempPos;
        if ( MaxPos == MinPos )
        {
            TempPos.x = MinPos.transform.position.x;
            TempPos.y = MinPos.transform.position.y;
            for ( int i = 1; i <= Height; i++ )
            {
                Instantiate(CubePrefab, TempPos, MinPos.transform.rotation, GetComponentInChildren<Transform>());
                TempPos.y = MinPos.transform.position.y + i;
            }
        }
        else
        {
            int TempX = (int)MinPos.transform.position.x;
            TempPos.y = MinPos.transform.position.y;
            while (TempX <= MaxPos.transform.localPosition.x)
            {
                TempPos.x = MinPos.transform.localPosition.x + TempX;
                Instantiate(CubePrefab, TempPos, MinPos.transform.rotation, GetComponentInChildren<Transform>());
                TempX++;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
