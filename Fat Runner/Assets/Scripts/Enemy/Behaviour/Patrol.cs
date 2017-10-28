using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

	public EnemyMove MoveScript;

	void OnTriggerEnter2D(Collider2D other)
	{
		
		if( other.tag.Equals("Player") )
		{
				if( other.transform.position.x > transform.position.x )
				{
					MoveScript.SetMovingLeft(false);
					MoveScript.SetSpeedofChase();
				}
				else
				{
					MoveScript.SetMovingLeft(true);
					MoveScript.SetSpeedofChase();
				}
		}

	}

	void OnTriggerExit2D(Collider2D other)
	{
		if( other.tag.Equals("Player") )
		{
			MoveScript.SetSpeedOfPatrol();
		}
	}

}
