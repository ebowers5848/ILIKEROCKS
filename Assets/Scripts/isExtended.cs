using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isExtended : MonoBehaviour
{
    public bool isExt;
    public int chainLength;
    private GameObject boneA;
    private  GameObject boneB;
    private GameObject boneC;
    private float angleAB;
    private float angleBC;
    private float angleAC;

    //private float angleAB;


    // Start is called before the first frame update
    void Start()
    {
        isExt = false;
        boneA = this.gameObject;
        boneB = boneA.transform.parent.gameObject;
        boneC = boneB.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chainLength == 2)
        {
            angleAB = Quaternion.Angle(boneA.transform.rotation, boneB.transform.rotation);
            if(angleAB < 10f)
            {
                isExt = true;
            }
            else isExt = false;
            
        }

        if (chainLength == 3)
        {
            angleAB = Quaternion.Angle(boneA.transform.rotation, boneB.transform.rotation);
            angleBC = Quaternion.Angle(boneB.transform.rotation, boneC.transform.rotation);
            //Debug.Log(boneA.name + " | Angle AB: " + angleAB + "Angle BC: " + angleBC);

            if(angleAB < 10 && angleBC <10){
                isExt = true;
            }
            else isExt = false;
        }
    }
}
