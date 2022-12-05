using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogic : MonoBehaviour
{
    public Rigidbody2D rigibod;
    bool grab;
    public GameObject bone;
    public GameObject effector;
    GameObject anchor;
    public GameObject anchorPrefab;
    public GameObject[] anchors = new GameObject[4];
    //public Rigidbody2D climberGuy; 
    //public SpriteRenderer handSR;
    //public UnityEngine.U2D.Animation.SpriteResolver resolver;
    //public Sprite open;
    //public Sprite closed;
    

    

    // Start is called before the first frame update
    void Start()
    {
        grab = false;
        //rigibod = GetComponent<Rigidbody2D>(); 
        //climberGuy = this.transform.parent.GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    void Update()
    {
        
        if(grab == true)
        {
            print("graby");
            
            effector.transform.position = anchor.transform.position;
            bone.transform.position = anchor.transform.position;
            //rigibod.constraints = RigidbodyConstraints2D.FreezePositionX;
            //handSR.sprite = closed;
        }
        
    //grab = false;

    }

    void OnCollisionEnter2D(Collision2D col)
        {   
            Debug.Log(col.gameObject.name + " is colliding with " + gameObject.name + " at " + Time.time);
            if(col.gameObject.CompareTag("hold"))
            {
                
                grab = true;
                //if (anchors[1])

                anchor = Instantiate(anchorPrefab, col.gameObject.transform.position, Quaternion.identity);

                

            }
        }

    void OnCollisionExit2D(Collision2D col)
        {   
            Debug.Log(col.gameObject.name + " no longer colliding with " + gameObject.name + " at " + Time.time);
            if(col.gameObject.CompareTag("hold"))
            {
                
                grab = false;
                //if (anchors[1])

                Destroy(anchor);

                

            }
        }
}