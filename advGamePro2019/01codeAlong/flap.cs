using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap : MonoBehaviour
{

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private int lastTouchCount = 0;
    void Update()
    {
        bool touch = (lastTouchCount == 0 && Input.touchCount > 0);
        lastTouchCount = Input.touchCount;

        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0) || touch)
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            transform.Rotate(Vector3.forward * 20);
        }
        else
        {
            transform.Rotate(Vector3.forward * -0.37f);
        }
    }
}
