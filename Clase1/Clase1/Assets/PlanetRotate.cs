using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour {

    public float Speed;
    private MeshRenderer MyMeshRenderer;
    private uint Step;
    public uint Color;

	// Use this for initialization
	void Start () {
        MyMeshRenderer = GetComponent<MeshRenderer>();
        Step = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.right * Time.deltaTime);
        transform.RotateAround(transform.parent.position, Vector3.up * Time.deltaTime, Speed);

        if( Step >= 10 )
        {
            Step = 0;
            Color++;
            if( Color >= 10 )
            {
                Color = 0;
            }
            switch( Color )
            {
                case 0:
                    
                    MyMeshRenderer.material.color = new UnityEngine.Color(0, 100, 0, 100);
                    break;

                case 1:
                    MyMeshRenderer.material.color = new UnityEngine.Color(0, 100, 0, 100);
                    break;

                case 2:
                    MyMeshRenderer.material.color = new UnityEngine.Color(0, 0, 100, 100);
                    break;

                case 3:
                    MyMeshRenderer.material.color = new UnityEngine.Color(100, 0, 100, 100);
                    break;

                case 4:
                    MyMeshRenderer.material.color = new UnityEngine.Color(0, 100, 100, 100);
                    break;

                case 5:
                    MyMeshRenderer.material.color = new UnityEngine.Color(100, 100, 0, 100);
                    break;

                case 6:
                    MyMeshRenderer.material.color = new UnityEngine.Color(10, 10, 10, 100);
                    break;

                case 7:
                    MyMeshRenderer.material.color = new UnityEngine.Color(20, 20, 20, 100);
                    break;

                case 8:
                    MyMeshRenderer.material.color = new UnityEngine.Color(0, 0, 0, 100);
                    break;

                case 9:
                    MyMeshRenderer.material.color = new UnityEngine.Color(15, 15, 15, 100);
                    break;



            }

        }
        else
        {
            Step++;
        }


    }
}
