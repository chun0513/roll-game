﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {

    public Transform player;

    
    Vector3 offset;
    

	// Use this for initialization
	void Start () {

        offset = transform.position - player.position;
     
	}
	
	// Update is called once per frame
	void Update () {


            transform.position = player.position + offset;
	}
}
