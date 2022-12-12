using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorCycler : MonoBehaviour
{
    // The list of colors to cycle through
    public Color[] colors;

    public int timeInterval;

    // The current index in the list of colors
    private int currentIndex = 0;

    // The camera component
    private Camera cam;

    void Start()
    {
        // Get the camera component
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        // Get the current color and the next color in the list
        Color currentColor = colors[currentIndex];
        Color nextColor = colors[(currentIndex + 1) % colors.Length];

        // Lerp from the current color to the next color over time
        cam.backgroundColor = Color.Lerp(currentColor, nextColor, Time.deltaTime * timeInterval);

        // If the current color is almost the same as the next color,
        // it's time to move to the next color in the list
        if (Mathf.Abs(cam.backgroundColor.r - nextColor.r) < 0.01f &&
            Mathf.Abs(cam.backgroundColor.g - nextColor.g) < 0.01f &&
            Mathf.Abs(cam.backgroundColor.b - nextColor.b) < 0.01f)
        {
            currentIndex = (currentIndex + 1) % colors.Length;
        }
    }
}

