using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	// Variables para uso externo
	public int Step;

	// Variables para uso del script
	private bool isMovingLeft;

    // Use this for initialization
    void Start () {
		
		isMovingLeft = true;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if( isMovingLeft )
		{
			transform.Translate( Vector2.left * Step * Time.deltaTime );
		}
		else
		{
			transform.Translate( Vector2.right * Step * Time.deltaTime );
		}

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if( !other.transform.tag.Equals("Player") && !other.transform.tag.Equals("Floor") )
		{
			isMovingLeft = !isMovingLeft;
		}
	}

	public void SetMovingLeft(bool Change)
	{
		isMovingLeft = Change;
	}

	public void SetSpeedofChase()
	{
		Step = Step * 2;
	}

	public void SetSpeedOfPatrol()
	{
		Step = Step / 2;
	}

}
