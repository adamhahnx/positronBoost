using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-(80 + int.Parse(GameObject.Find("score").GetComponent<UnityEngine.UI.Text>().text)), 0), ForceMode2D.Force);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
    	if(col.gameObject.name == gameObject.name)
    	{
    	    return;
    	}
        rb.mass = 0.2f;
        Invoke("GameOver", 1.5f);
        AudioSource aso = GameObject.Find("music").GetComponent<AudioSource>();
        aso.volume *= 1.5f;
        aso.pitch *= 0.95f;
    }
    
    void GameOver()
    {
    	Application.LoadLevel(Application.loadedLevel);
    }
}
