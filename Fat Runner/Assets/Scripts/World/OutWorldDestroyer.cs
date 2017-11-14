﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutWorldDestroyer : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.GetComponent<PlayerMove>().DestroyPlayer();
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
