using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour {

    public void GoToPlay()
    {
        SceneManager.LoadScene("InGame", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Additive);
    }

}
