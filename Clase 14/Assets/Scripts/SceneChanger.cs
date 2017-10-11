using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	public void DoChangeScene()
	{
		SceneManager.LoadScene("ANewWorld", LoadSceneMode.Single);
	}

}
