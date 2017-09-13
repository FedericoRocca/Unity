using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour {

    public int Impulse;
    public GameObject[] MyGObjects;

	// Use this for initialization
	void Start () {
		
        for( int i = 0; i < MyGObjects.Length; i++ )
        {
            MyGObjects[i].AddComponent<ConstantForce>();
            MyGObjects[i].GetComponent<Rigidbody>().AddForce(new Vector3( Random.Range(-1,2), Random.Range(-1, 2), Random.Range(-1, 2)) * Impulse);
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
