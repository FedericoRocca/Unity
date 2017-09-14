using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    public int Step = 10;
    public Vector3 InitialPosition = new Vector3(0, 0, 10);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + (Vector3.back * Time.deltaTime * Step);

        if(transform.position.z <= -10 )
        {
            transform.position = InitialPosition;
            transform.position = new Vector3( Random.Range(-5,6), Random.Range(-5, 6), InitialPosition.z ) ;
        }

	}
}
