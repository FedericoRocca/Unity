using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRain : MonoBehaviour {

    public GameObject[] GobjPrefabs;

	// Use this for initialization
	void Start () {
        InvokeRepeating("InstantiateRandomFood", 1.0f, 1.0f);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void InstantiateRandomFood()
    {
        GameObject ObjInstantiated;
        for( int i = 0; i < GobjPrefabs.Length; i++ )
        {
            ObjInstantiated = Instantiate(GobjPrefabs[i], transform);

            ObjInstantiated.transform.position = new Vector3( Random.Range(-10, 10) , Random.Range(10, 30), 0);

            Destroy(ObjInstantiated, 5.0f);
        }
    }

}
