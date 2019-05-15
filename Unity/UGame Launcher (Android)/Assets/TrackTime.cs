using System;
using System.Diagnostics;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrackTime : MonoBehaviour {

    int playTimeCounter = 0;
    Text myTxt;
    float theTime;
    public float speed = 1;
    bool run = false;

    // Use this for initialization
    void Start () {
        myTxt = GameObject.Find("Canvas/CurrentPlaySession").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		if (run == true)
        {
            theTime += Time.deltaTime * speed;
            string seconds = (theTime % 60).ToString("00");
            myTxt.text = seconds;
        }
	}

    public void OnMouseButton()
    {
        // Stopwatch gameTime = new Stopwatch();

        myTxt.text = "Started!";
        run = true;
    }
}
