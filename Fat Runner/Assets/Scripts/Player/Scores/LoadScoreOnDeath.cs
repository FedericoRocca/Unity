using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScoreOnDeath : MonoBehaviour {

    private Text Lost;

	// Use this for initialization
	void Start () {
        Lost = GetComponent<Text>();

        Lost.text = "Tu puntaje fue de " + PlayerPrefs.GetInt("Score") + " puntos!";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
