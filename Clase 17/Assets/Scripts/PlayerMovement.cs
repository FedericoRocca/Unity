using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float Step;
	private SpriteRenderer MySpriteRenderer;

	// Use this for initialization
	void Start () {

		MySpriteRenderer = GetComponent<SpriteRenderer>();
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 MyMinPos = Camera.main.WorldToViewportPoint( MySpriteRenderer.bounds.min );
		Vector3 MyMaxPos = Camera.main.WorldToViewportPoint( MySpriteRenderer.bounds.max );
		
		/*
		Vector3 LeftSide = Camera.main.ViewportToWorldPoint( new Vector3(0, 0, 0) );
		LeftSide += MySpriteRenderer.bounds.extents;
		
		Vector3 RightSide = Camera.main.ViewportToWorldPoint( new Vector3(1, 0, 0) );
		RightSide -= MySpriteRenderer.bounds.extents;
		RightSide.y = -3.5;
		*/

		float LeftSide = Camera.main.ViewportToWorldPoint( new Vector3(0, 0, 0) );

		if( Input.GetKey( KeyCode.RightArrow ) )
		{
			if( MyMaxPos.x <= 1 )
			{
				transform.Translate( Vector3.right * Step * Time.deltaTime );
			}
		}

		if( Input.GetKey( KeyCode.LeftArrow ) )
		{
			if( MyMinPos.x >= 0 )
			{				
				transform.Translate( Vector3.left * Step * Time.deltaTime );
			}
		}

		if( MyMinPos.x < 0 )
		{
			transform.position = LeftSide;
		}

		if( MyMaxPos.x > 1 )
		{
			transform.position = RightSide;
		}
		
	}

}
