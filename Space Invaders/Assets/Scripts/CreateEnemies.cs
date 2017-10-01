using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemies : MonoBehaviour {

	public GameObject ShipPrefab;
	private const int MaxShipsWidht = 5;
	private const int MaxShipsHeight = 4;

	private GameObject[,] ShipsMats = new GameObject[MaxShipsHeight, MaxShipsWidht];

	private Vector3 ShipsPos = new Vector3(0, 10, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake()
	{

		for( int i = 0; i < MaxShipsHeight; i++ )
		{
			for( int a = 0; a < MaxShipsWidht; a++ )
			{
				ShipsMats[i,a] = Instantiate( ShipPrefab, ShipsPos, Quaternion.identity );
				ShipsPos.x++;
			}

			ShipsPos.x = 0;
			ShipsPos.y -- ;

		}
	}

}
