﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputBehaviour : InputBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    protected override void Update ()
    {
        
		base.Update();
        if (Input.GetKeyDown(KeyCode.B))
            print("b down");
    }
}