using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {

    private bool IsJumping;
    public int Force;
    private Rigidbody MyRigidBody;

    // Use this for initialization
    void Start () {

        IsJumping = false;
        MyRigidBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

        CheckCharMove();

        if( Input.GetKeyDown( KeyCode.Space ) )
        {
            CharJump();
        }
		
	}

    void CheckCharMove()
    {

        if(!IsJumping)
        {

            if( Input.GetKey( KeyCode.RightArrow ) )
            {
                MoveRight();
            }
            else if(Input.GetKey(KeyCode.LeftArrow))
            {
                MoveLeft();
            }

        }

    }

    void MoveRight()
    {
        transform.position = transform.position + (Vector3.right * Time.deltaTime * Force);
    }

    void MoveLeft()
    {
        transform.position = transform.position + Vector3.left * Time.deltaTime * Force;
    }

    void CharJump()
    {
        IsJumping = true;
        MyRigidBody.AddForce(Vector3.up * Force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "Piso" )
        {
            IsJumping = false;
        }
    }

}
