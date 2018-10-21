using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public GameObject target;//the object we want to bring it
    public GameObject targetgirl;
    void boys()
    {
        Instantiate(target, new Vector3(-48.94593f, -4.2f, -22.01f), Quaternion.identity);
//eturn 0;
    }

    void girls()
    {
        Instantiate(targetgirl, new Vector3(-48.94593f, -4.2f, -17.01f), Quaternion.identity);
        //eturn 0;
    }
    // Use this for initialization
    void Start () {

        while (Time.realtimeSinceStartup != 11)
        {
            Invoke("boys", 1);
            Invoke("girls", 3);
        }
      
        //Invoke("boys",3);
        //Invoke("boys",5);
        //Invoke("girls", 1);
        //Invoke("girls", 3);
        //Invoke("girls", 5);


    }
	
	// Update is called once per frame
	void Update () {
      //  Invoke("boys", );


        Destroy(target, 3);
	}
}
