using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInputName : MonoBehaviour {

	private InputField ThisInput;

	// Use this for initialization
	void Start () {

		ThisInput = gameObject.GetComponent<InputField>();
		ThisInput.placeholder.GetComponent<Text>().text = PlayerPrefs.GetString( "PlayerName");
		ThisInput.onValueChanged.AddListener(SaveName);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SaveName(string Name)
	{
		PlayerPrefs.SetString( "PlayerName", Name );
	}

    

}
