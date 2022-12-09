using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogic : MonoBehaviour
{
<<<<<<< Updated upstream
    Rigidbody2D rigibod;
    bool grab;
    public SpriteRenderer handSR;
    public UnityEngine.U2D.Animation.SpriteResolver resolver;
    public Sprite open;
    public Sprite closed;
=======
    public bool isgrabbing;
    public GameObject target;
    public GameObject bone;
    public GameObject[] anchors = new GameObject[4];

    private GameObject anchor;

    //public Rigidbody2D climberGuy; 
    //public SpriteRenderer handSR;
    //public UnityEngine.U2D.Animation.SpriteResolver resolver;
    //public Sprite open;
    //public Sprite closed;
>>>>>>> Stashed changes
    

    

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



<<<<<<< Updated upstream
    // Update is called once per frame
    void Update()
    {
        
        if(grab == true)
        {
            print("graby");
            rigibod.constraints = RigidbodyConstraints2D.FreezePosition;
            handSR.sprite = closed;
=======
        if (Input.GetMouseButtonDown(0)) {
            if (target.GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePos)){
                Destroy(anchor);
                isgrabbing = false;
            }
>>>>>>> Stashed changes
        }
        

    }

<<<<<<< Updated upstream
    void OnTriggerEnter2D(Collider2D col)
        {   
            Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            if(col.gameObject.CompareTag("hold"))
            {
                grab = true;
                resolver.SetCategoryAndLabel("Hand", "Closed");
                resolver.ResolveSpriteToSpriteRenderer();
            }
=======
    void OnCollisionEnter2D(Collision2D col) {   
        Debug.Log(col.gameObject.name + " is colliding with " + gameObject.name + " at " + Time.time);

        if(col.gameObject.CompareTag("hold") && !anchor) {
			anchor = new GameObject();
            anchor.transform.position = col.gameObject.transform.position;
            isgrabbing = true;
>>>>>>> Stashed changes
        }
}
