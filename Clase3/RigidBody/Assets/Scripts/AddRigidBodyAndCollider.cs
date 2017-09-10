using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidBodyAndCollider : MonoBehaviour {

    void Awake()
    {
        transform.gameObject.AddComponent<SphereCollider>();
        transform.gameObject.AddComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
