using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundManager : MonoBehaviour {

    public SpriteRenderer[] SpritesToManage;
    private float[] HorizontalSizeOfSprites;

    // Use this for initialization
    void Start () {

        HorizontalSizeOfSprites = new float[SpritesToManage.Length];

        for( int i = 0; i < SpritesToManage.Length; i++ )
        {
            HorizontalSizeOfSprites[i] = SpritesToManage[i].size.x;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		for( int i = 0; i < SpritesToManage.Length; i++ )
        {
            if (Camera.main.WorldToViewportPoint(SpritesToManage[i].transform.position).x < -1)
            {
                SpritesToManage[i].transform.position = new Vector3(SpritesToManage[i].transform.position.x + (HorizontalSizeOfSprites[i] * SpritesToManage.Length), SpritesToManage[i].transform.position.y, 0);
            }
        }
	}
}
