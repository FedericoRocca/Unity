using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffMeshRendererOnAwake : MonoBehaviour {

    private Renderer MyRenderer;
    
    void Awake()
    {
        MyRenderer = transform.GetComponent<Renderer>();
        MyRenderer.enabled = false;
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update () {
		
	}
}
