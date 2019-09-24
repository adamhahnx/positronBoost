using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    private UnityEngine.UI.Text s;
    private UnityEngine.UI.Text h;
    private AudioSource aso;
    
    void Start()
    {
        s = GameObject.Find("score").GetComponent<UnityEngine.UI.Text>();
        h = GetComponent<UnityEngine.UI.Text>();
        h.text = PlayerPrefs.GetInt("high").ToString();
        aso = GetComponent<AudioSource>();
    }
    
    bool oneTime = true;
    
    void Update()
    {
        if (int.Parse(s.text) > PlayerPrefs.GetInt("high"))
        {
            PlayerPrefs.SetInt("high", int.Parse(s.text));
            h.text = s.text;
            if(oneTime)
            {
                aso.Play();
                oneTime = false;
            }
        }
    }
}
