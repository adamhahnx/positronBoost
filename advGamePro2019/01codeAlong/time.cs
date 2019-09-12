using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

    Text score;

	void Start ()
    {
        score = GetComponent<UnityEngine.UI.Text>();
    }

    float rawTime = 0f;

    void Update ()
    {
        rawTime += Time.deltaTime;
        score.text = ((int)rawTime).ToString();
    }
}
