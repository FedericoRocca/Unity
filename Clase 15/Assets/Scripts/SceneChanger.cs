using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	private Button ThisButton;
	void Start () {
		ThisButton = gameObject.GetComponent<Button>();
		ThisButton.onClick.AddListener( ChangeToIngame );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void ChangeToIngame()
	{
		SceneManager.LoadScene( "InGame", LoadSceneMode.Single );
	}

}
