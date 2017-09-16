using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutOfWorld : MonoBehaviour {

    public GameObject[] Enemy;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < Enemy.Length; i++)
        {
            transform.position = new Vector3(Random.Range(-9, 9), 1, Random.Range(-9, 9));
        }


    }
	
	// Update is called once per frame
	void Update () {
		for( int i = 0; i < Enemy.Length; i++ )
        {
            if (Enemy[i].transform.position.y <= -2)
            {
                Enemy[i].transform.position = new Vector3(Random.Range(-9, 9), 1, Random.Range(-9, 9));
            }
        }
	}
}
