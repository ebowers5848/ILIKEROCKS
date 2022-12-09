using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    private float vel = 0f;
    private float acc = 0.0000005f;
    private HandLogic leftHandLogic;
    private HandLogic rightHandLogic;
    public Rigidbody2D rigibod;
    public GameObject climberGuy;
    // Start is called before the first frame update
    void Start()
    {
        leftHandLogic = climberGuy.transform.GetChild(14).GetChild(3).GetChild(0).GetChild(0).Find("Left Hand_1").GetComponent<HandLogic>();
        Debug.Log("Left Hand Logic Found");
        rightHandLogic = climberGuy.transform.GetChild(14).GetChild(4).GetChild(0).GetChild(0).Find("Right Hand_1").GetComponent<HandLogic>();
        Debug.Log("Right Hand Logic Found");
    }

    // Update is called once per frame
    void Update()
    {
        if(rightHandLogic.isgrabbing && leftHandLogic.isgrabbing) {
            vel += acc;
            rigibod.MovePosition(new Vector2(this.transform.position.x, this.transform.position.y + vel));
        }
        
    }
}
