using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicVariables : MonoBehaviour {

    public int Speed;
    public bool ImGreen;
    private MeshRenderer MyMesh;
    
	// Use this for initialization
	void Start () {
        //GetComponent<Transform>().position = new Vector3(Speed, 1, 0);
        MyMesh = GetComponent<MeshRenderer>();

        if ( ImGreen )
        {
            MyMesh.material.color = Color.green;
        }
        else
        {
            MyMesh.material.color = Color.red;
        }

        transform.position = new Vector3(Speed, 1, 0);

    }
	
	// Update is called once per frame
	void Update () {
	}
}
