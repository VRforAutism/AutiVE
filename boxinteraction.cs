using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//box object hase two animation open and close 
//broken into two parts the code will control the top part
//in this class 

public class boxinteraction : MonoBehaviour
{
    //this method will allow to create a collection of related constants state
    public enum State
    {
        box_open,
        box_close,
        inbetween,
    }

    public State state;
    public Animation anim;
    

    public AudioSource audio;// to play clap audio
    public Transform player;
    public float rayLenght = 30f;

    // Use this for initialization
    void Start()
    {
        //get component from scene and store it in these variables
        anim = GetComponent<Animation>();
        audio = GetComponent<AudioSource>();
        state = boxinteraction.State.box_close;//by default close
    }

    
   

    //first function of the enterGaze event
    public void EnterGaze()
    {
        
        state = boxinteraction.State.box_open;
       
        Debug.Log("Enter");
    }

    //first function of the exitGaze event
    public void ExitGaze()
    {
        Debug.Log("Exit");
        
        state = boxinteraction.State.box_close;
    }


//to truck the box in witch state(open, close,in between)
//check state if box open call open function if close call close function
   public void onGazeUp()
    {
        try { 
        switch (state)
        {
            case State.box_open:
                state = boxinteraction.State.inbetween;
                StartCoroutine("open");
                break;
            case State.box_close:
                state = boxinteraction.State.inbetween;
                StartCoroutine("open");
                break;
        }
        }
        catch (System.Exception e)
        {
            Debug.LogException(e, this);
        }
        //   if (state == boxinteraction.State.box_open)
        //       open();
        //  else
        //    close();
    }

    //open box, play audio, and change state to open 
    private IEnumerator open()
    {
        anim.Play("box_open");

        yield return new WaitForSeconds(anim["box_open"].length);
        audio.Play();
        state = boxinteraction.State.box_open;

    }


    //close box, and change state to close 
    private IEnumerator close()
    {
        anim.Play("box_close");
        yield return new WaitForSeconds(anim["box_close"].length);
        state = boxinteraction.State.box_close;
    }

}
