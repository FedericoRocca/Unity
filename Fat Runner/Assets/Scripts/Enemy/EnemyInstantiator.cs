using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiator : MonoBehaviour {

    public GameObject EnemyPrefab;

	// Use this for initialization
	void Start () {
        Instantiate( EnemyPrefab, GetComponentInChildren<Transform>().position, GetComponentInChildren<Transform>().rotation, GetComponentInChildren<Transform>());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
