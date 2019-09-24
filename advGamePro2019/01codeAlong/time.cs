using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

    Text score;
    int high;

	void Start ()
    {
        score = GetComponent<UnityEngine.UI.Text>();
        high = PlayerPrefs.GetInt("high");
    }

    float rawTime = 0f;

    void Update ()
    {
        score.text = ((int)rawTime).ToString();
        if (high > 60 && int.Parse(score.text) < high)
        {
            rawTime += Time.deltaTime * (PlayerPrefs.GetInt("high") / 60f);
        }
        else
        {
            rawTime += Time.deltaTime;
        }
    }
}
