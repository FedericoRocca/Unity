using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public int MoveVelocity = 10;
	private bool MoveLeft = true;
	private bool MoveRight = false;
	private bool MoveDown = false;
	private bool MoveUp = false;
	private float MyTimer = 0.0f;

	// Use this for initialization
	void Start () {
		InvokeRepeating( "MoveDownEnemyShip", 5.0f, 20.0f );
		InvokeRepeating( "MoveUpEnemyShip", 15f, 20.0f );
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void FixedUpdate()
	{
		MyTimer += Time.deltaTime;

		if( MoveLeft == true && transform.position.x >= -7.18f )
		{
			transform.Translate( Vector3.left * Time.deltaTime * MoveVelocity );
		}
		else
		{
			MoveRight = true;
			MoveLeft = false;
		}
		
		if( MoveRight == true && transform.position.x <= 7.18f )
		{
			transform.Translate( Vector3.right * Time.deltaTime * MoveVelocity );
			MoveLeft = false;
		}
		else
		{
			MoveRight = false;
			MoveLeft = true;
		}

		if( MoveDown == true && MyTimer <= 2 )
		{
			transform.Translate( Vector3.down * Time.deltaTime );
		}

		if( MoveUp == true && MyTimer <= 2 )
		{
			transform.Translate( Vector3.up * Time.deltaTime );
		}
		
		

	}

	void MoveDownEnemyShip()
	{
		MoveDown = true;
		MoveUp = false;
		MyTimer = 0.0f;
	}

	void MoveUpEnemyShip()
	{
		MoveDown = false;
		MoveUp = true;
		MyTimer = 0.0f;
	}
	
}
