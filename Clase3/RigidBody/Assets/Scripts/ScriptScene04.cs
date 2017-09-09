using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScene04 : MonoBehaviour {

    public int Step;
    public GameObject MyGameObject;

    // Use this for initialization
    void Start() {
        MyGameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        MyGameObject.transform.position = new Vector3(4,4,0);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.right * Step * Time.deltaTime;
        MyGameObject.transform.position += Vector3.left * Step * Time.deltaTime;
    }
}
