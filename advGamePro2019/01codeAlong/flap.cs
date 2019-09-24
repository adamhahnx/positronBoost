using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flap : MonoBehaviour
{

    Rigidbody2D rb;
    private UnityEngine.UI.Text t;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        t  = GameObject.Find("taps").GetComponent<UnityEngine.UI.Text>();
        t.text = PlayerPrefs.GetInt("taps").ToString();
    }

    int lastTouchCount = 0;
    void Update()
    {
        bool touch = (lastTouchCount == 0 && Input.touchCount > 0);
        lastTouchCount = Input.touchCount;

        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0) || touch)
        {
            rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            transform.Rotate(Vector3.forward * 20);
            PlayerPrefs.SetInt("taps", PlayerPrefs.GetInt("taps") + 1);
            t.text = PlayerPrefs.GetInt("taps").ToString();
        }
        else
        {
            transform.Rotate(Vector3.forward * -0.37f);
        }
    }
}
