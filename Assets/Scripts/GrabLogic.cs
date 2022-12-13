using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabLogic : MonoBehaviour
{
    // Audio for Rock Grab sound effect
    private GameObject SoundEffectsGameObject;
    public AudioClip grabSoundEffect;
    public AudioClip releaseSoundEffect;
    public AudioClip winSoundEffect;
    public GameObject target;
    public GameObject[] anchors = new GameObject[4];
    public bool isGrabbing;
    private GameObject anchor;

    //public Rigidbody2D climberGuy; 
    //public SpriteRenderer handSR;
    //public UnityEngine.U2D.Animation.SpriteResolver resolver;
    //public Sprite open;
    //public Sprite closed;
    

    

    // Start is called before the first frame update
    void Start() {
        
       
        SoundEffectsGameObject = new GameObject();
        SoundEffectsGameObject.AddComponent(typeof(AudioSource));

    }

    // Update is called once per frame
    void Update() {
        if (anchor) {
            isGrabbing = true;
            target.transform.position = anchor.transform.position;
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            if (target.GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePos)){
                Destroy(anchor);
                isGrabbing = false;

                // Play release sound effect
                SoundEffectsGameObject.GetComponent<AudioSource>().PlayOneShot(releaseSoundEffect);
            }
        }


    }

    void OnTriggerEnter2D(Collider2D col) {   
        //Debug.Log(col.gameObject.name + " is colliding with " + gameObject.name + " at " + Time.time);

        // Play grab sound effect
        SoundEffectsGameObject.GetComponent<AudioSource>().PlayOneShot(grabSoundEffect);

        // Create anchor
        if(col.gameObject.CompareTag("hold") && !anchor) {
			anchor = new GameObject();
            anchor.transform.position = col.gameObject.transform.position;
        }

        if(col.gameObject.tag == "ceiling") {
            // Play winning sound effect
            SoundEffectsGameObject.GetComponent<AudioSource>().PlayOneShot(winSoundEffect);
        }
    }

}