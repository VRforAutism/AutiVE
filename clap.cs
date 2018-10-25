using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clap : MonoBehaviour
{

    static Animator anime;
    public float countdown = 1000.0f;


    void Start()
    {
        anime = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        /*
         if(OVRInput.RawButton("clap"){
         anime.ResetTrigger("clap");
         }

         if(OVRInput.RawTouch("handRaising"){
         anime.ResetTrigger("handRaising");
         }

         */


        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)//the girl will clap after 10 seconds
        {
            anime.ResetTrigger("clap");
        }
        if(countdown == 5.0f)
        {
            anime.SetTrigger("handRaising");
        }
    }
}
