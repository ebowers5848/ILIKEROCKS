using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    private float vel = 0f;
    private float acc = 0.00005f;
    public Rigidbody2D rigibod;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vel -= acc;
        rigibod.MovePosition(new Vector2(this.transform.position.x, this.transform.position.y + vel));
    }
}
