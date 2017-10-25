using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	
	//Variables para uso externo
	public int Step;
	public int JumpForce;
	public int EnemyJumpForce;

	// Variables para uso del script
	private Rigidbody2D MyRigidBody;
	private bool IsInAir;

	// Use this for initialization
	void Start () {
		MyRigidBody = transform.GetComponent<Rigidbody2D>();
		IsInAir = true;
	}
	
	// Update is called once per frame
	void Update () {

		// Movimiento izquierda
		if( Input.GetKey( KeyCode.A ) || Input.GetKey( KeyCode.LeftArrow ) )
		{
			MoveLeft();
		}

		// Movimiento derecha
		if( Input.GetKey( KeyCode.D ) || Input.GetKey( KeyCode.RightArrow ) )
		{
			MoveRight();
		}

		// Salto
		if( Input.GetKeyDown( KeyCode.Space ) || Input.GetKey( KeyCode.UpArrow ) )
		{
			Jump();
		}

	}

	private void MoveLeft()
	{
		transform.Translate( Vector3.left * Step * Time.deltaTime );
	}

	private void MoveRight()
	{
        transform.Translate( Vector3.right * Step * Time.deltaTime );
	}

	private void Jump()
	{
        if( !IsInAir )
		{
			MyRigidBody.AddForce(Vector3.up * JumpForce, ForceMode2D.Force);
			IsInAir = true;
		}
	}

	private void BounceOnEnemy()
	{
		MyRigidBody.AddForce(Vector3.up * EnemyJumpForce, ForceMode2D.Force);
	}

	void OnCollisionEnter2D(Collision2D other)
	{

		if( other.transform.tag.Equals("Floor") )
		{
			IsInAir = false;
		}

		if( other.transform.tag.Equals("Enemy") )
		{
			if( other.contacts[0].point.y == other.contacts[1].point.y )
			{
				BounceOnEnemy();
			}
			else
			{
				Destroy( this.gameObject );
			}
		}

	}

}
