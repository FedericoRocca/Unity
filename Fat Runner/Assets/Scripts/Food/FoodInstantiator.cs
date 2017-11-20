using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstantiator : MonoBehaviour {

    public GameObject[] FoodsPrefs;

	// Use this for initialization
	void Start () {
            Instantiate(FoodsPrefs[Random.Range(0, FoodsPrefs.Length - 1)], transform.position, Quaternion.identity, transform);        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
