using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    public int Step;
    public GameObject[] Enemies;
    private int[] InitialZ;

	// Use this for initialization
	void Start () {

        InitialZ = new int[Enemies.Length];

        for (int i = 0; i < Enemies.Length; i++)
        {
            InitialZ[i] = Random.Range(15, 26);
            Enemies[i].transform.position = new Vector3(Random.Range(-5, 6), Random.Range(-5, 6), InitialZ[i]);
        }

    }
	
	// Update is called once per frame
	void Update () {
        for( int i = 0; i < Enemies.Length; i++ )
        {
            Enemies[i].transform.position = Enemies[i].transform.position + (Vector3.back * Time.deltaTime * Step);

            if (Enemies[i].transform.position.z <= -10)
            {
                Enemies[i].transform.position = new Vector3(Random.Range(-5, 6), Random.Range(-5, 6), InitialZ[i]);
            }
        }

	}
}
