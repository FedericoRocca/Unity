using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignRandomColor : MonoBehaviour {

    public GameObject[] Cards;
    private bool[] IsAssigned;

	// Use this for initialization
	void Start () {
        IsAssigned = new bool[Cards.Length];

        for( int i = 0; i < Cards.Length; i++ )
        {
            
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
