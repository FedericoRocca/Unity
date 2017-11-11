using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	
	//Variables para uso externo
	public int Step; // Velocidad horizontal
	public int JumpForce;  // Fuerza de salto
	public int EnemyJumpForce; // Fuerza de salto al rebotar en un enemigo

	// Variables para uso del script
	private Rigidbody2D MyRigidBody;
	private CapsuleCollider2D MyCollider;
	private bool IsInAir;

	public GameObject pies;

	// Use this for initialization
	void Start () {
		// Obtengo el rigidbody, para poder agregarle fuerza y demas
		MyRigidBody = transform.GetComponent<Rigidbody2D>();

		// Se restrinje el salto en el primer frame, evitando un salto en el aire
		IsInAir = true;

		// Obtengo el collider
		MyCollider = transform.GetComponent<CapsuleCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if(Camera.main.WorldToViewportPoint(MyRigidBody.transform.position).x >= 0.05f)
        {
            // Movimiento izquierda
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                MoveLeft();
            }

        }
        else
        {
            MyRigidBody.velocity = new Vector2(-0 * Step, MyRigidBody.velocity.y);
        }

        // Movimiento derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }


        // Salto
        if ( Input.GetKey( KeyCode.UpArrow ) )
		{
			Jump();
		}

	}

	// Movimiento hacia la izquierda
	private void MoveLeft()
	{
            MyRigidBody.velocity = new Vector2(-1 * Step, MyRigidBody.velocity.y);
	}

	// Movimiento hacia la derecha
	private void MoveRight()
	{
            MyRigidBody.velocity = new Vector2(1 * Step, MyRigidBody.velocity.y);
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
		Collider2D colHitting = Physics2D.OverlapCircle(pies.transform.position, 0.05f);
		if (colHitting != null && (colHitting.transform.tag.Equals("Floor")  || colHitting.transform.tag.Equals("Wall")))
		{
			IsInAir = false;
		}

		if( other.transform.tag.Equals("Enemy") )
		{

			RaycastHit2D Left;
			RaycastHit2D Right;
			RaycastHit2D Center;
	
			Vector3 Origin;
			Vector3 Destination;

            // Genero raycasts hacia abajo, para validar la colision con enemigos desde arriba
			// Left
			Origin = new Vector3( MyCollider.bounds.center.x - MyCollider.size.x / 4 + 0.1f, MyCollider.bounds.center.y, 0 );
			Destination = new Vector3( MyCollider.bounds.center.x - MyCollider.size.x / 4 + 0.1f, MyCollider.bounds.center.y - MyCollider.size.y / 4 - 0.1f, 0 );
			Left = Physics2D.Linecast( Origin, Destination );
			
			// Center
			Origin = new Vector3( MyCollider.bounds.center.x , MyCollider.bounds.center.y );
			Destination = new Vector3( MyCollider.bounds.center.x , MyCollider.bounds.center.y - MyCollider.size.y / 4 - 0.1f, 0 );
			Right = Physics2D.Linecast( Origin, Destination );
			
			// Right
			Origin = new Vector3( MyCollider.bounds.center.x + MyCollider.size.x / 4 - 0.1f, MyCollider.bounds.center.y, 0 );
			Destination = new Vector3( MyCollider.bounds.center.x + MyCollider.size.x / 4 - 0.1f, MyCollider.bounds.center.y - MyCollider.size.y / 4 - 0.1f, 0 );
			Center = Physics2D.Linecast( Origin, Destination );

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
