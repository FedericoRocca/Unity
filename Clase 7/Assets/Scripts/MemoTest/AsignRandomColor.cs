using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignRandomColor : MonoBehaviour {

    public GameObject[] Cards;
    private bool[] IsAssigned;

	// Use this for initialization
	void Start () {

        IsAssigned = new bool[Cards.Length];
        for( int r = 0; r < IsAssigned.Length; r++ ) // Inicializo en false
        {
            IsAssigned[r] = false;
        }

        for( int i = 0; i < Cards.Length; i++ ) // Recorro las cartas
        {

            Cards[i].GetComponent<Renderer>().material.color = Random.ColorHSV(); // Asigno un color aleatorio a la carta
            
            while(IsAssigned[i] == false)
            {
                int RandPos = Random.Range(0, Cards.Length);
                if ( IsAssigned[RandPos] == false )
                {
                    Cards[RandPos].GetComponent<Renderer>().material.color = Cards[i].GetComponent<Renderer>().material.color;
                    IsAssigned[RandPos] = true;
                }

            }

        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
