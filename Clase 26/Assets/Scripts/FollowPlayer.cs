using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour {

    public Transform PlayerPos;
    public NavMeshAgent MyNavMesh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MyNavMesh.SetDestination(PlayerPos.position);
	}
}
