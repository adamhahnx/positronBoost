﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounds : MonoBehaviour {

    void Update()
    {
        if (transform.position.y < -6.0f)
        {
            transform.position = new Vector2(-5.0f, 6.0f);
        }
        else if(transform.position.y > 6.0f)
        {
            transform.position = new Vector2(-5.0f, -5.0f);
        }
    }
}
