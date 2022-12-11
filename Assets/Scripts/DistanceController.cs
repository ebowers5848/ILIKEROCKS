using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceController : MonoBehaviour
{
    public GameObject GameObject1;
    public GameObject GameObject2;
    public float thresholdDistance = 1.0f;
    public float moveAmount = 0.1f;

    void Update()
    {
        // Calculate the distance between the two GameObjects
        float distance = Vector3.Distance(GameObject1.transform.position, GameObject2.transform.position);

        // If the distance is less than the threshold distance, move GameObject1 away from GameObject2
        if (distance > thresholdDistance)
        {
            Vector3 direction = GameObject1.transform.position - GameObject2.transform.position;
            GameObject1.transform.position -= direction.normalized * moveAmount;
        }
    }
}
