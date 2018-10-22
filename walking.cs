using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour {
    //static Animator anim;
    //public float speed = 10.0F;
    //public float rotationSpeed = 100.0F;
    // Vector3 velocity = new Vector3(-55.9f, 15.24f, 14.9f);
    // Use this for initialization
    public GameObject boys;
    [SerializeField]
    GameObject Thedoor;
   // public GameObject theDoor;


    void Insboys()
    {
        
            Instantiate(boys, new Vector3(-48.367f, -4.2f, -22.01f), Quaternion.identity);
        
    }

    void Start () {
        //      anim = GetComponent<Animator>();
       // boys = GetComponent<GameObject>();
        Invoke("Insboys", 5);
        Invoke("Insboys", 10);
        
       
	}
   

    // Update is called once per frame
    void Update () {
        if(transform.position.z >= -18.44f)

        {
         //   Thedoor.transform.position = new Vector3(Thedoor.transform.position.x, Thedoor.transform.position.y, -2.43f);
           Thedoor.transform.Translate(Vector3.left * Time.deltaTime * 0.1f);
        }
        if (Time.realtimeSinceStartup >25)
        {
            Thedoor.transform.position = new Vector3(-0.2f, -0.34f, -1.68f);
        }
    //  Destroy(boys, 2);

            // -52.6, 15.3, 17.3
            //    Vector3 p = this.gameObject .transform.position;
            //    Vector3 sstop = new Vector3(-53.3f, -11.1f, 19.3f);
            //    float translation = Input.GetAxis("Vertical") * speed;
            //    float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            //    translation *= Time.deltaTime;
            //    rotation *= Time.deltaTime;
            //    //transform.Translate(0, 0, translation);
            //    //  transform.Rotate(0, rotation, 0);
            //    Debug.Log(p);
            //    if (transform.position.z == 19.3)
            //    {
            //        Debug.Log("ttttttttt");
            //        // anim.SetTrigger("stop");
            //    }
            //    else
            //    {
            //        Debug.Log("elseee");
            //    }



    }
}
