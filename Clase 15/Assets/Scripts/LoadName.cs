using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadName : MonoBehaviour {

	private string PlayerName;

	// Use this for initialization
	void Start () {
		PlayerName = PlayerPrefs.GetString( "PlayerName", "" );
		gameObject.GetComponent<Text>().text += PlayerName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
