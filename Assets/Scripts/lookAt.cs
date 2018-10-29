using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.rotation = Quaternion.Euler(0, 100, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
