using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogic : MonoBehaviour
{
    public Rigidbody2D rigibod;
    bool grab;
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
            //rigibod.constraints = RigidbodyConstraints2D.FreezeAll;
            //handSR.sprite = closed;
        }
        

    }

    void OnCollisionEnter2D(Collision2D col)
        {   
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            if(col.gameObject.CompareTag("hold"))
            {
                
                grab = true;
                
            }
        }
}