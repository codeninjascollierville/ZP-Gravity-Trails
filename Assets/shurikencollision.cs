﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikencollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("eeee");
        }
    }
}
