using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate()
	{
		Debug.Log( Time.realtimeSinceStartup );
		transform.position = Vector3.Lerp( Vector3.left * 10, Vector3.right * 10, Time.timeSinceLevelLoad );
	}
}
