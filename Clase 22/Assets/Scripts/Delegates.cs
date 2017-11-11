using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Delegates : MonoBehaviour {

	public Button GoToLol;
	public Button GoToDerp;

	// Use this for initialization
	void Start () {
		GoToLol.onClick.AddListener( delegate() { SceneManager.LoadScene( "LOL", LoadSceneMode.Single ); } );
		GoToDerp.onClick.AddListener( delegate() { SceneManager.LoadScene( "Derp", LoadSceneMode.Single ); } );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
