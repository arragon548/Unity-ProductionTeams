﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateProjectile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        this.transform.Rotate(0,90*Time.deltaTime,0);
	}
}
