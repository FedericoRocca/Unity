using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBarManager : MonoBehaviour {

	public Slider StaminaBar;
	private Rigidbody2D MyRigidBody;
	private PlayerMove DeathCaller;
    float Augmentation = 25.0f;

    // Use this for initialization
    void Start () {
		MyRigidBody = GetComponentInParent<Rigidbody2D>();
		DeathCaller = GetComponentInParent<PlayerMove>();
	}
	
	// Update is called once per frame
	void Update () {

		if( DeathCaller.IsAlive() )
		{
			StaminaBar.value -= Time.deltaTime * 2;

			if( MyRigidBody.mass >= 1.0f )
			{
				MyRigidBody.mass = (StaminaBar.value / 100) * 2;
			}

			if( StaminaBar.value <= 0.0f )
			{
				DeathCaller.DestroyPlayer();
			}
		}
		
	}

    public void MoreStamina()
    {
        if((StaminaBar.value + Augmentation) > 100 )
        {
            StaminaBar.value = 100;
        }
        else
        {
            StaminaBar.value = StaminaBar.value + Augmentation;
        }
    }

}
