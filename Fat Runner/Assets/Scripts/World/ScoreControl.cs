using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreControl : MonoBehaviour {

	private Text ScoreText;

	private Vector3 PrevCamPosition;
	private string ScoreString = "Puntaje: ";
	private int Score = 0;

	// Use this for initialization
	void Start () {
		ScoreText = GetComponent<Text>();
		PrevCamPosition = Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if( PrevCamPosition != Camera.main.transform.position )
		{
			
			Score += (int)Camera.main.transform.position.x - (int)PrevCamPosition.x;
			PrevCamPosition = Camera.main.transform.position;

		}
		ScoreText.text = ScoreString + Score;

	}
}
