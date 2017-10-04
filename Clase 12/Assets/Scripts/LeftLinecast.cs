using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLinecast : MonoBehaviour {

	private Vector3 lcstart;
	private Vector3 lcend;
	public GameObject PartSystem;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		lcstart = gameObject.transform.position;
		lcend = Vector3.right * 100;
		
		RaycastHit HitLineCast;
		if( Physics.Linecast( lcstart, lcend, out HitLineCast ) )
		{
			HitLineCast.transform.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 2);
			Instantiate( PartSystem, HitLineCast.transform.position, Quaternion.identity );
			Debug.DrawLine(lcstart, lcend);
		}

	}
}
