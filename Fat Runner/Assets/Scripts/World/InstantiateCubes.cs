using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour {

    public GameObject CubePrefab;
    public GameObject CubePrefabInit;
    public GameObject CubePrefabEnd;
    public GameObject MinPos;
    public GameObject MaxPos;
    public int Height;
    public bool IsFloatingIsland = false;

	// Use this for initialization
	void Start () {
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
            if( IsFloatingIsland == false )
            {
                int TempX = (int)MinPos.transform.position.x;
                TempPos.y = MinPos.transform.position.y;
                while (TempX <= MaxPos.transform.position.x)
                {
                    TempPos.x = MinPos.transform.localPosition.x + TempX;
                    Instantiate(CubePrefab, TempPos, MinPos.transform.rotation, GetComponentInChildren<Transform>());
                    TempX++;
                }
            }
            else
            {
                int TempX = (int)MinPos.transform.position.x;
                TempPos.y = MinPos.transform.position.y;
                while (TempX <= MaxPos.transform.position.x)
                {
                    TempPos.x = MinPos.transform.localPosition.x + TempX;
                    if( TempX == (int)MinPos.transform.position.x )
                    {
                        Instantiate(CubePrefabInit, TempPos, MinPos.transform.rotation, GetComponentInChildren<Transform>());
                    }
                    else if(TempX == (int)MaxPos.transform.position.x)
                    {
                        Instantiate(CubePrefabEnd, TempPos, MinPos.transform.rotation, GetComponentInChildren<Transform>());
                    }
                    else
                    {
                        Instantiate(CubePrefab, TempPos, MinPos.transform.rotation, GetComponentInChildren<Transform>()); 
                    }
                    TempX++;
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
