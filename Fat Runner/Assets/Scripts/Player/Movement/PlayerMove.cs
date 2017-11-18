using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {
	
	//Variables para uso externo
	public int Step; // Velocidad horizontal
	public int JumpForce;  // Fuerza de salto
	public int EnemyJumpForce; // Fuerza de salto al rebotar en un enemigo

	// Variables para uso del script
	private Rigidbody2D MyRigidBody;
	private CapsuleCollider2D MyCollider;
	public bool IsInAir;
    private bool IsFacingRight = true;
    public AudioSource JumpSound;
    public AudioSource DeathSound;
	public bool IsDead = false;
	private float DeadTime;
    public bool IsMoving = false;

    public GameObject pies;

	public bool IsAlive()
	{
		if( DeadTime <= 0 )
		{
			return false;
		} else return true;
	}

    public void DestroyPlayer()
    {
        if( !IsDead )
		{
			AudioSource.PlayClipAtPoint(DeathSound.clip, Camera.main.transform.position, DeathSound.volume);
			IsDead = true;
			SpriteRenderer[] Renderers;
			Renderers = gameObject.GetComponentsInChildren<SpriteRenderer>();

			for( int i = 0; i < Renderers.Length; i++ )
			{
				Renderers[i].enabled = false;
			}

			gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
		}

    }

    // Use this for initialization
    void Start () {
		// Obtengo el rigidbody, para poder agregarle fuerza y demas
		MyRigidBody = transform.GetComponent<Rigidbody2D>();

		// Obtengo el collider
		MyCollider = transform.GetComponent<CapsuleCollider2D>();

		DeadTime = 2.0f;
	}
	
	// Update is called once per frame
	void Update()
	{
		if( IsDead == true )
		{
			DeadTime -= Time.deltaTime;
		}
	}

	void FixedUpdate () {

        if(Camera.main.WorldToViewportPoint(MyRigidBody.transform.position).x >= 0.05f)
        {
            // Movimiento izquierda
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if( IsFacingRight )
                {
                    transform.Rotate(Vector3.up * 180);
                }
                
                MoveLeft();
            }

        }
        else
        {
            MyRigidBody.velocity = new Vector2(0 * Step, MyRigidBody.velocity.y);
        }

        // Movimiento derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if( !IsFacingRight )
            {
                transform.Rotate(Vector3.up * 180);
            }
            MoveRight();
        }

		// Salto
        if ( Input.GetKey( KeyCode.UpArrow ) )
		{
			Jump();
		}

        if( Input.GetKeyUp( KeyCode.LeftArrow ) || Input.GetKeyUp(KeyCode.RightArrow) )
        {
            IsMoving = false;
        }

	}

	// Movimiento hacia la izquierda
	private void MoveLeft()
	{
        MyRigidBody.velocity = new Vector2(-1 * Step, MyRigidBody.velocity.y);
        IsFacingRight = false;
        IsMoving = true;
	}

	// Movimiento hacia la derecha
	private void MoveRight()
	{
        MyRigidBody.velocity = new Vector2(1 * Step, MyRigidBody.velocity.y);
        IsFacingRight = true;
        IsMoving = true;
    }

	// Salto
	private void Jump()
	{
        if( !IsInAir && MyRigidBody.velocity.y <= 0 )
		{
            JumpSound.Play();
			MyRigidBody.AddForce(Vector3.up * JumpForce, ForceMode2D.Force);
			IsInAir = !IsInAir;
		}
	}

	// Salto producido por caer sobre un enemigo
	private void BounceOnEnemy()
	{
        JumpSound.Play();
        MyRigidBody.AddForce(Vector3.up * EnemyJumpForce, ForceMode2D.Force);
	}

	// Deteccion de colision
	void OnCollisionEnter2D(Collision2D other)
	{
		Collider2D colHitting = Physics2D.OverlapCircle(pies.transform.position, 0.05f);
		if (colHitting != null && (colHitting.transform.tag.Equals("Enemy") || 
									colHitting.transform.tag.Equals("Floor")  || 
									colHitting.transform.tag.Equals("Wall")))
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

			if( Left.transform != null )
			{
				if( Left.transform.tag.Equals("Enemy") )
				{
					BounceOnEnemy();
					Destroy(other.gameObject);
					return;
				}
			}

			if( Right.transform != null )
			{
				if( Right.transform.tag.Equals("Enemy") )
				{
					BounceOnEnemy();
					Destroy(other.gameObject);
					return;
				}
			}

			if( Center.transform != null )
			{
				if( Center.transform.tag.Equals("Enemy") )
				{
					BounceOnEnemy();
					Destroy(other.gameObject);
					return;
				}
			}

                DestroyPlayer();
			
		}

	}

}
