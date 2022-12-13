using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathDetect : MonoBehaviour
{
    private GameObject SoundEffectsGameObject;
    public AudioClip deathSoundEffect;

    void Start() {
        SoundEffectsGameObject = new GameObject();
        SoundEffectsGameObject.AddComponent(typeof(AudioSource));
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "floor") {
            SoundEffectsGameObject.GetComponent<AudioSource>().PlayOneShot(deathSoundEffect);
        }
    }
}
