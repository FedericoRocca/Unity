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
	private BoxCollider2D MyCollider;
	private bool IsInAir;

	// Use this for initialization
	void Start () {
		// Obtengo el rigidbody, para poder agregarle fuerza y demas
		MyRigidBody = transform.GetComponent<Rigidbody2D>();

		// Se restrinje el salto en el primer frame, evitando un salto en el aire
		IsInAir = true;

		// Obtengo el collider
		MyCollider = transform.GetComponent<BoxCollider2D>();
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
			MyRigidBody.velocity = new Vector2( -1 * Step , MyRigidBody.velocity.y);
	}

	// Movimiento hacia la derecha
	private void MoveRight()
	{
				MyRigidBody.velocity = new Vector2( 1 * Step , MyRigidBody.velocity.y);
	}

	// Salto
	private void Jump()
	{
        if( !IsInAir )
		{
			MyRigidBody.AddForce(Vector3.up * JumpForce, ForceMode2D.Force);
			IsInAir = !IsInAir;
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

		// Si colisiono contra un GO tageado como "Floor" reseteo la variable de salto
		if( other.transform.tag.Equals("Floor") || other.transform.tag.Equals("Wall"))
		{
			IsInAir = !IsInAir;
		}

		// FIXME
		if( other.transform.tag.Equals("Enemy") )
		{

			RaycastHit2D Left = Physics2D.Linecast( new Vector3( transform.position.x - ( MyCollider.size.x / 2 + 0.2f) , transform.position.y, 0),  transform.position + (Vector3.down * 3));
			RaycastHit2D Right = Physics2D.Linecast( new Vector3( transform.position.x + ( MyCollider.size.x / 2 - 0.2f) , transform.position.y, 0),  transform.position + (Vector3.down * 3));
			RaycastHit2D Center = Physics2D.Linecast( transform.position,  transform.position + (Vector3.down * 3));
			
			if( Left.transform.tag.Equals("Enemy") || Right.transform.tag.Equals("Enemy") || Center.transform.tag.Equals("Enemy") )
			{
				Destroy(other.gameObject);
			}
			else
			{
				Destroy(this.gameObject);
			}
			
		}

	}

}
