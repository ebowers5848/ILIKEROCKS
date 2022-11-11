using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogic : MonoBehaviour
{
    Rigidbody2D rigibod;
    bool grab;
    public SpriteRenderer handSR;
    public UnityEngine.U2D.Animation.SpriteResolver resolver;
    public Sprite open;
    public Sprite closed;
    

    

    // Start is called before the first frame update
    void Start()
    {
        grab = false;
        rigibod = GetComponent<Rigidbody2D>(); 
        handSR = GetComponent<SpriteRenderer>();   
        resolver = GetComponent<UnityEngine.U2D.Animation.SpriteResolver>();
        open = Resources.Load("Sprites/hand/hand_open.png") as Sprite;
        closed = Resources.Load("Sprites/hand/hand_closed.png") as Sprite;


    }



    // Update is called once per frame
    void Update()
    {
        
        if(grab == true)
        {
            print("graby");
            rigibod.constraints = RigidbodyConstraints2D.FreezePosition;
            handSR.sprite = closed;
        }
        

    }

    void OnTriggerEnter2D(Collider2D col)
        {   
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            if(col.gameObject.CompareTag("hold"))
            {
                grab = true;
                resolver.SetCategoryAndLabel("Hand", "Closed");
                resolver.ResolveSpriteToSpriteRenderer();
            }
        }
}
