using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour {

    public bool xRotation;
    public float xSpeed;
    public bool yRotation;
    public float ySpeed;
    public bool zRotation;
    public float zSpeed;

    private float x = 0;
    private float y = 0;
    private float z = 0;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(xRotation)
            x += xSpeed; 
        if(yRotation)
            y += ySpeed;
        if(zRotation)
            z += zSpeed;

        transform.rotation = Quaternion.Euler(x, y, z);


	}
}
