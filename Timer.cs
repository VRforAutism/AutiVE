using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    [SerializeField]
    // float timer = 10f;//scne timer
    
    public string loadScene;//this to load a scene after timer end
    
    public Text timerText;//display timer
    private float start;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();//get the text on the obj
        start = Time.time;//scince time start
	}
	
	// Update is called once per frame
	void Update () {
      //  timer -= Time.deltaTime;
       float t  =Time.time - start;
       // timerText.text = timer.ToString("f0");
        
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");
        timerText.text = min + " : " + sec;
        int x = int.Parse(min);

        if (x == 1)
        {
            SceneManager.LoadScene("EndScen");
        }

    }
}
