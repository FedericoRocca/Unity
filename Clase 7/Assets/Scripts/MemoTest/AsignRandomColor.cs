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
            for(int a = 0; a < Cards.Length; a++) // Como cada carta tiene que tener su par, asigno el color de la carta a otra en la grilla
            {

                if( IsAssigned[a] == false ) // Si no fue asignado el color, busco otra
                {
                    Cards[a].GetComponent<Renderer>().material.color = Cards[i].GetComponent<Renderer>().material.color;
                    IsAssigned[a] = true;
                }

            }

        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
