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
		// Obtengo el rigidbody, para poder agregarle fuerza y demas
		MyRigidBody = transform.GetComponent<Rigidbody2D>();

		// Se restrinje el salto en el primer frame, evitando un salto en el aire
		IsInAir = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

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

	// Movimiento hacia la izquierda
	private void MoveLeft()
	{
		transform.Translate( Vector3.left * Step * Time.deltaTime );
	}

	// Movimiento hacia la derecha
	private void MoveRight()
	{
        transform.Translate( Vector3.right * Step * Time.deltaTime );
	}

	// Salto
	private void Jump()
	{
        if( !IsInAir )
		{
			MyRigidBody.AddForce(Vector3.up * JumpForce, ForceMode2D.Force);
			IsInAir = true;
		}
	}

	// Salto producido por caer sobre un enemigo
	private void BounceOnEnemy()
	{
		MyRigidBody.AddForce(Vector3.up * EnemyJumpForce, ForceMode2D.Force);
	}

	// Deteccion de colision
	void OnCollisionEnter2D(Collision2D other)
	{

		//* Al momento de colisionar, está cambiando la posicion de y, por ende está matando al jugador incorrectamente */
		
		if( other.transform.tag.Equals("Floor") )
		{
			IsInAir = false;
		}

		if( other.transform.tag.Equals("Enemy") )
		{
			if( other.contacts[0].point.y.ToString("0.0") == other.contacts[1].point.y.ToString("0.0") )
			{
				BounceOnEnemy();
				Destroy( other.gameObject );
			}
			else
			{
				Destroy( this.gameObject );
			}
		}

	}

}
