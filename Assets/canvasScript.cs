using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasScript : MonoBehaviour {

    public Text timerText;
    public float startTime;

    
    public void Start()
    {
        startTime = Time.time;
        timerText = GameObject.Find("timerText").GetComponent<Text>(); ;

    }

    public void FixedUpdate()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = "czas: " + minutes + ":" + seconds ;
    }
}
