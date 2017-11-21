using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entro en el trgger");
        if (collision.transform.tag.Equals("Player")) 
        {
            if (SceneManager.GetActiveScene().name.Equals("InGame"))
            {
                Debug.Log("Change to FirstLevel");
                SceneManager.LoadScene("FirstLevel", LoadSceneMode.Single);
                return;
            }
        }
        else
        {
            Debug.Log("False InGame");
        }

        if (collision.transform.tag.Equals("Player"))
        {
            if (SceneManager.GetActiveScene().name.Equals("FirstLevel"))
            {
                Debug.Log("Change to Victory");
                SceneManager.LoadScene("Victory", LoadSceneMode.Single);
                return;
            }
        }
        else
        {
            Debug.Log("False FirstLevel");
        }

    }
}
