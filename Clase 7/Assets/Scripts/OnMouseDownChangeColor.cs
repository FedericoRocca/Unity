using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseDownChangeColor : MonoBehaviour {

    private Renderer MyRenderer;

	// Use this for initialization
	void Start () {
        MyRenderer = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        MyRenderer.material.color = Random.ColorHSV();
    }

}
