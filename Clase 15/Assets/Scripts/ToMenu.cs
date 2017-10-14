using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ToMenu : MonoBehaviour {

	private Button ThisMenu;
	// Use this for initialization
	void Start () {
		
		ThisMenu = gameObject.GetComponent<Button>();
		ThisMenu.onClick.AddListener(ReturnToMenu);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void ReturnToMenu()
	{
		SceneManager.LoadScene( "Menu", LoadSceneMode.Single );
	}

}
