using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {
    bool dragging;
    Collider2D collider;

    void Start() {
        collider = GetComponent<Collider2D>();
        dragging = false;
    }

    void Update() {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            if (collider == Physics2D.OverlapPoint(mousePos)) {
                dragging = true;
            }
        }

        if (dragging) {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0)) {
            dragging = false;
        }
    }
}