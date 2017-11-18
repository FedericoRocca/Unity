using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    private Animator MyAnimator;
    private PlayerMove MovePlayer;

    // Use this for initialization
    void Start() {
        MyAnimator = GetComponent<Animator>();
        MovePlayer = GetComponent<PlayerMove>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if( MovePlayer.IsInAir )
        {
            MyAnimator.SetBool("Jumping", true);
        }
        else
        {
            MyAnimator.SetBool("Jumping", false);
        }

        if( MovePlayer.IsMoving )
        {
            MyAnimator.SetBool("Moving", true);
        }
        else
        {
            MyAnimator.SetBool("Moving", false);
        }

        if( MovePlayer.IsDead )
        {
            MyAnimator.SetBool("Dying", true);
        }
        else
        {
            MyAnimator.SetBool("Dying", false);
        }

        if( MyAnimator.GetBool("Jumping") == false && MyAnimator.GetBool("Moving") == false && MyAnimator.GetBool("Dying") == false)
        {
            MyAnimator.SetBool("Idling", true);
        }
        else
        {
            MyAnimator.SetBool("Idling", false);
        }


    }
}
