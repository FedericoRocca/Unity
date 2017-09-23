using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGrua : MonoBehaviour {

	private bool MovingLeft = true;
    public float Speed = 0;

	void Start () {
		
	}

	void Update () {

		if (MovingLeft == true)
        {
            transform.position = transform.position + ( Vector3.left * Time.deltaTime * Speed );
        }
        else
        {
            transform.position = transform.position + (Vector3.right * Time.deltaTime * Speed);
        }

        if(transform.position.x >= 5)
        {
            MovingLeft = true;
        }
        else if(transform.position.x <= -5)
        {
            MovingLeft = false;
        }

	}
}