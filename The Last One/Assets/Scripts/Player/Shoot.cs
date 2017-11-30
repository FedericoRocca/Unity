using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public float Cadency;
    private float TimePassed = 0.0f;
    public GameObject Weapon;
    private GameObject WeaponCannonPos;
    public ParticleSystem ShootParticle;
    public float DurationTime;
    private ParticleSystem CreatedParticle;
    public AudioClip ShootClip;

    // Use this for initialization
    void Start () {
        WeaponCannonPos = GameObject.FindGameObjectWithTag("Weapon");
	}
	
	// Update is called once per frame
	void Update () {

        if( Input.GetMouseButtonDown( 0 ) )
        {
            DoShot();
        }

        if( Input.GetMouseButton( 0 ) )
        {
            TimePassed += Time.deltaTime;
            if (TimePassed >= Cadency)
            {
                DoShot();
                TimePassed = 0.0f;
            }
        }

        if( Input.GetMouseButtonUp( 0 ) )
        {
            TimePassed = 0.0f;
        }
	
	}

    private void DoShot()
    {
        CreatedParticle = Instantiate(ShootParticle, WeaponCannonPos.transform);
        AudioSource.PlayClipAtPoint(ShootClip, WeaponCannonPos.transform.position);
        Destroy(CreatedParticle.gameObject, DurationTime);
    }
}
