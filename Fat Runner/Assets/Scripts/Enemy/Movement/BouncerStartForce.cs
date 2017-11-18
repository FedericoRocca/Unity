using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerStartForce : MonoBehaviour {
	public int LeftForce = 0;
    public ParticleSystem JumpParticles;

	// Use this for initialization
	void Start () {
		transform.GetComponent<Rigidbody2D>().AddForce( Vector2.left * LeftForce, ForceMode2D.Force );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ParticleSystem Particles = Instantiate(JumpParticles, transform.position, transform.rotation);
        Destroy(Particles.gameObject, 1.0f);
    }
}
