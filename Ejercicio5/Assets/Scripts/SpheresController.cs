using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresController : MonoBehaviour {

    public GameObject[] Balls;
    public bool ExecuteRandomColorAndUseGravity;
    private int counter;
    public int FramesRestart;

    // Use this for initialization
    void Start () {
        counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (ExecuteRandomColorAndUseGravity)
        {
            RandomColorAndUserGravity();
        }

        if (counter >= FramesRestart)
        {
            RestartAll();
            counter = 0;
        }
        else counter++;

    }

    private void RandomColorAndUserGravity()
    {
        for (int i = 0; i < Balls.Length; i++)
        {
            if (Random.Range(0, 2) == 1)
            {
                Balls[i].GetComponent<Rigidbody>().useGravity = true;
                Balls[i].GetComponent<Renderer>().material.color = Random.ColorHSV();
            }
        }
    }

    private void RestartAll()
    {
        for( int i = 0; i < Balls.Length; i++ )
        {
            Balls[i].transform.position = Balls[i].GetComponent<CollisionDetector>().OriginalPosition;
        }
    }

}
