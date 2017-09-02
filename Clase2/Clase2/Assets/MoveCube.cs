using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime * Speed;
        transform.position += Vector3.right * Speed * Time.deltaTime;
	}
}
