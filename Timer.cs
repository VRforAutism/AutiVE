using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float start;

	// Use this for initialization
	void Start () {
        start = Time.time;//scince time start
	}
	
	// Update is called once per frame
	void Update () {
      float t  =Time.time - start;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");
        timerText.text = min + " : " + sec;

	}
}
