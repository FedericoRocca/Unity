using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBallEnteringInRoom : MonoBehaviour {

    public Rigidbody TrapDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        TrapDoor.useGravity = true;
    }

}
