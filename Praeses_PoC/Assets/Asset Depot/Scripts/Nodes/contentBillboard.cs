﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contentBillboard : MonoBehaviour {



	// Use this for initialization
	void Start () {


        //transform.LookAt(Camera.main.transform.position, Camera.main.transform.up);

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 lookPos = Camera.main.transform.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*2);

    }
}
