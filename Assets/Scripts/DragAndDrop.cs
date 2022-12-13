using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour {
    bool dragging;
    Collider2D circleCollider;
    public GameObject effector;
    public isExtended[] scriptlist;
    

	// for use in RotateBody()
    public GameObject body;
    public GameObject head;

    void Start() {
        circleCollider = GetComponent<Collider2D>();
        dragging = false;
    }

    void Update() {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            if (circleCollider == Physics2D.OverlapPoint(mousePos)) {
                dragging = true;
            }
        }

        if (dragging) {
            this.transform.position = mousePos;

            if (gameObject.tag == "body_move_target") {
                if(!scriptlist[0].isExt && !scriptlist[1].isExt && !scriptlist[2].isExt && !scriptlist[3].isExt){
                    effector.transform.position = Vector2.Lerp(effector.transform.position, this.transform.position, Time.deltaTime);
                }
            }

            if (gameObject.tag == "body_rotate_target") {
                RotateBody();
            }
        }

        if (Input.GetMouseButtonUp(0)) {
            this.transform.position = effector.transform.position;
            dragging = false;
        }
        
    }

    void RotateBody() {
        float angle = Vector3.Angle(body.transform.up, head.transform.position - this.transform.position);
        body.transform.rotation = Quaternion.RotateTowards(body.transform.rotation, Quaternion.Euler(0, 0, angle), 1);
    }
}