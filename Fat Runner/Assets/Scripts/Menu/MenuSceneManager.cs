using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneManager : MonoBehaviour {

    public void GoToPlay()
    {
        SceneManager.LoadScene("InGame", LoadSceneMode.Single);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
    }

    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

}
