﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
   // public GameObject propeller;
    Vector3 offset = new Vector3(20, 5, 9);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         transform.position = plane.transform.position + offset;
      //  transform.Rotate(0f, 270f, 0f , Space.World);
    }
}
