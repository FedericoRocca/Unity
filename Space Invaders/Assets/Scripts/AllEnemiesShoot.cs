using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemiesShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating( "AllShoot", 0.0f, 10.0f );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
