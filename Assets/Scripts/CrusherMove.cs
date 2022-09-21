﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherMove : MonoBehaviour

{
    public Rigidbody2D rrb;
    public int minimumYPosition;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= minimumYPosition)
        {
            rrb.AddForce(transform.up * 400f);
        }
    }
}
