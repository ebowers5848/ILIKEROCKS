using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogic : MonoBehaviour
{
    public GameObject target;
    public GameObject[] anchors = new GameObject[4];

    private GameObject anchor;

    //public Rigidbody2D climberGuy; 
    //public SpriteRenderer handSR;
    //public UnityEngine.U2D.Animation.SpriteResolver resolver;
    //public Sprite open;
    //public Sprite closed;
    

    

    // Start is called before the first frame update
    void Start() {
        //rigibod = GetComponent<Rigidbody2D>(); 
        //climberGuy = this.transform.parent.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update() {
        if (anchor) {
            target.transform.position = anchor.transform.position;
        }

        //rigibod.constraints = RigidbodyConstraints2D.FreezePositionX;
        //handSR.sprite = closed;
        //grab = false;
    }

    void OnCollisionEnter2D(Collision2D col) {   
        Debug.Log(col.gameObject.name + " is colliding with " + gameObject.name + " at " + Time.time);

        if(col.gameObject.CompareTag("hold") && !anchor) {
			anchor = new GameObject();
            anchor.transform.position = col.gameObject.transform.position;
        }
    }

    void OnCollisionExit2D(Collision2D col) {   
        Debug.Log(col.gameObject.name + " no longer colliding with " + gameObject.name + " at " + Time.time);

        if(col.gameObject.CompareTag("hold") && anchor) {
            Destroy(anchor);
        }
    }
}