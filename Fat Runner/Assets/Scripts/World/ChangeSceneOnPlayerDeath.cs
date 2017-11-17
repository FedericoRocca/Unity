using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnPlayerDeath : MonoBehaviour {

	public GameObject Player;
	private PlayerMove IsDead;

	// Use this for initialization
	void Start () {
		IsDead = Player.gameObject.GetComponent<PlayerMove>();
	}
	
	// Update is called once per frame
	void Update () {
		if( !IsDead.IsAlive() )
		{
			Destroy( Player.gameObject, 2.0f );
			SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
		}
	}
}
