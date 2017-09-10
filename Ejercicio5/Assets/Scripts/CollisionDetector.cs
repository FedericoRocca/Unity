using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {

    public Vector3 OriginalPosition;

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision ObjectCollision)
    {
        Debug.Log("Enter, object: " + ObjectCollision.transform.GetComponent<Transform>().name);
        this.GetComponent<Rigidbody>().velocity = new Vector3( Random.Range(-5, 5), Random.Range(-5, 5), 0 );
    }

    void OnCollisionStay( Collision ObjectCollision)
    {
        Debug.Log("Stay, object: " + ObjectCollision.transform.GetComponent<Transform>().name);
    }

    void OnCollisionExit( Collision ObjectCollision )
    {
        Debug.Log("Exit, object: " + ObjectCollision.transform.GetComponent<Transform>().name);
    }
    
}
