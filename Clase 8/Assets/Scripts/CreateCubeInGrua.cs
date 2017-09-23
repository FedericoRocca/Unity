using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubeInGrua : MonoBehaviour {

	public GameObject CubePrefab;

	// Use this for initialization
	void Start () {
		CubePrefab.transform.position = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetKeyDown( KeyCode.Space ) )
		{
			// Instanciar un prefab
			Instantiate( CubePrefab, CubePrefab.transform.position, Quaternion.identity);
		}

	}
}
