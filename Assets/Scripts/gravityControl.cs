using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityControl : MonoBehaviour
{
    private GameObject SoundEffectsGameObject;
    public AudioClip fallingSoundEffect;

    private Rigidbody2D rb;
    public GrabLogic[] extremities = new GrabLogic[4];  
    private int grabCount = 0;

    private bool fallingSoundPlayed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        SoundEffectsGameObject = new GameObject();
        SoundEffectsGameObject.AddComponent(typeof(AudioSource));
        
    }

    // Update is called once per frame
    void Update()
    {
        grabCount = 0;
        for (int i = 0; i <= 3; i++){
            if (extremities[i].isGrabbing){
                grabCount += 1;
            }
        }
        // Debug.Log("grabCount = " + grabCount);
        if (grabCount >= 3){
            rb.gravityScale = 0f;

        }
        else
        {
            rb.gravityScale = 0.15f;
            if (!fallingSoundPlayed) {
                SoundEffectsGameObject.GetComponent<AudioSource>().PlayOneShot(fallingSoundEffect);
                fallingSoundPlayed = true;
            }
        }
        
    }
}
