using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float MoveMentTime;
	public int Step;
	private float Auxtime;
	private bool MoveLeft;
	private int MovesCounter;

	// Use this for initialization
	void Start () {

		Auxtime = MoveMentTime;
		MoveLeft = true;
		MovesCounter = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void FixedUpdate()
	{
		MoveMentTime -= Time.deltaTime;

		if( MoveMentTime <= 0 )
		{
			MoveMentTime = Auxtime;

			if( MoveLeft == true )
			{
				transform.position += Vector3.left * Step;
				MovesCounter++;
				if( MovesCounter == 2 )
				{
					MoveLeft = false;
					MovesCounter = 0;
				}
			}
			else
			{
				transform.position += Vector3.right * Step;
				MovesCounter++;
				if( MovesCounter == 2 )
				{
					MoveLeft = true;
					MovesCounter = 0;
				}
			}

		}
	}
}
