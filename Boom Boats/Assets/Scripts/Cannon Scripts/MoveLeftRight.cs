﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour {
    public float rotationSpeed;
    public float rotationLimit;
    public Transform shootingPointTranform;
    public int location;

    private float startingXRotation;
    private float startingYRotation;

    // Use this for initialization
    void Start () {
        startingXRotation = transform.rotation.x;
        startingYRotation = transform.rotation.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0f, 1f, 0f), rotationSpeed * Time.deltaTime);
        
        if (location == 0 || location == 2 || location == 3)
        {
            /*
            if (location == 0)
            {
                Debug.Log("Start " + startingXRotation + " current x " + transform.rotation.x + " currentY " + transform.rotation.y);
            }*/
            if (rotationSpeed > 0)
            {
                if (transform.rotation.x > startingXRotation + rotationLimit)
                {
                    rotationSpeed *= -1;
                }
            }
            else
            {
                if (transform.rotation.x < startingXRotation - rotationLimit)
                {
                    rotationSpeed *= -1;
                }
            }
        }
        else if (location == 1)
        {
            if (rotationSpeed > 0)
            {
                if (transform.rotation.y < startingYRotation - rotationLimit)
                {
                    rotationSpeed *= -1;
                }
            }
            else
            {
                if (transform.rotation.y > startingYRotation + rotationLimit)
                {
                    rotationSpeed *= -1;
                }
            }
            //Debug.Log(transform.rotation.y);
        }
        
            //Debug.Log(startingXRotation /*+ " " + transform.rotation.x*/ + " " + location);
	}
}