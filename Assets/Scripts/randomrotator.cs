﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomrotator : MonoBehaviour {
	public float tumble;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {		
		rb=GetComponent<Rigidbody>();
		rb.angularVelocity= Random.insideUnitSphere*tumble;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
