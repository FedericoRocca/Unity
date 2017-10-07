using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour {

	public Vector3 StartingPosition;
	public Vector3 MiddlePosition;
	public Vector3 EndingPosition;

	private float timer;
	private bool MoveToEndingPosition = false;
	private bool MoveToStartingPosition = false;
	private bool MoveToMiddlePosition = false;
	private int PosCounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;

		if( timer >= 1 )
		{
			timer = 0;
			PosCounter++;

			if( PosCounter >= 3 )
			{
				PosCounter = 0;
			}

		}

		switch( PosCounter )
		{

			case 0:
				transform.position = Vector3.Lerp( StartingPosition, MiddlePosition, timer );
			break;

			case 1:
				transform.position = Vector3.Lerp( MiddlePosition, EndingPosition, timer );
			break;

			case 2:
				transform.position = Vector3.Lerp( EndingPosition, StartingPosition, timer );
			break;

		}

	}
}
