using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{

    int score = 0;
    int time = 0;

    public Text score1;
    public Text Time1;

    public bool check = false;
    public bool check1 = false;
  
    // Start is called before the first frame update
    void Start()
    {
        //get the text and score component from the scene 
        score1.GetComponent<Text>();
       Time1.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(check == false)
        {
            //The execution of a coroutine can be paused at any point using the yield statement
            //specify when need the next value
            StartCoroutine(score_delay());
            score1.text = "score: " + score;

        }

        if (check1 == false)
        {
            StartCoroutine(time_delay());
            Time1.text = "Time: " + time;

        }


    }

    //IEnumerator have set of variables like lis ورى بعض تكون 
    //one score every 5 seconds
    IEnumerator score_delay()
    {
        check = true;
        score = score + 1;

        //return statment
        yield return new WaitForSeconds(5f);
       
        check = false;
    }


    //claclate time
    IEnumerator time_delay()
    {
        check1 = true;
        time = time + 1;

        yield return new WaitForSeconds(1f);
        
        check1 = false;
    }
}
