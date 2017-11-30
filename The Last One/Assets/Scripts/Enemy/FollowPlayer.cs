using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour {

    private NavMeshAgent MyNavMeshAgent;
    public GameObject Objective;

    // Use this for initialization
    void Start () {
        MyNavMeshAgent = GetComponent<NavMeshAgent>();
        InvokeRepeating("PlayerFollow", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlayerFollow()
    {
        MyNavMeshAgent.SetDestination(Objective.transform.position);
    }

}
