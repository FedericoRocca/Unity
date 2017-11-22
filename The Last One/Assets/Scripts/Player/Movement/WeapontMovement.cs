using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapontMovement : MonoBehaviour {

    private Transform MyTransform;

	// Use this for initialization
	void Start () {
        MyTransform = GetComponentInParent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Rotation: ", MyTransform);
        MyTransform.rotation = Camera.main.transform.rotation;
	}
}
