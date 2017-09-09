using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter( Collision ObjectCollision )
    {
        Debug.Log("Enter, object: " + ObjectCollision.transform.GetComponent<GameObject>().name);
    }

    void OnCollisionStay( Collision ObjectColission )
    {
        Debug.Log("Stay, object: " + ObjectColission.transform.GetComponent<GameObject>().name);
    }

    void OnCollisionExit( Collision ObjectCollision )
    {
        Debug.Log("Exit, object: " + ObjectCollision.transform.GetComponent<GameObject>().name);
    }

}
