using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoresManager : MonoBehaviour {

    public ScoreControl Score;

	// Use this for initialization
	void Start () {

        if( SceneManager.GetActiveScene().name.Equals("InGame") )
        {
            PlayerPrefs.DeleteKey("Score");
        }
        else
        {
            Score.SetScore(PlayerPrefs.GetInt("Score"));
        }

	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetInt("Score", Score.GetScore() );
	}
}
