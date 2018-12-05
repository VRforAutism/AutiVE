using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstStudent : MonoBehaviour
{
    /*anim: this will link back and grab hold of the animator controller 
    that got atteached to student*/
    static Animator anim;
    
    

    // Start is called before the first frame update
    void Start()
    {
        //get the component of the animator and put it here
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //when time equal 6 seconds make the next animation from animator map
        if (Time.deltaTime == 3f)
        {
            anim.SetTrigger("writing");
        }

    }
}


