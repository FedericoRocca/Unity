using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorDetection : MonoBehaviour {

    public int JumpForce = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce( Vector3.up * JumpForce);
    }

}
