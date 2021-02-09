using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OneTouch : MonoBehaviour
{
    // Update is called once per frame
    void Update() {
    foreach (Touch touch in Input.touches) {

        if (touch.fingerId == 0) {
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                Debug.Log("First finger entered!");
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended) {
                Debug.Log("First finger left.");
            }
        }

        if (touch.fingerId == 1) {
            if (Input.GetTouch(1).phase == TouchPhase.Began) {
                Debug.Log("Second finger entered!");
            }
            if (Input.GetTouch(1).phase == TouchPhase.Ended) {
                Debug.Log("Second finger left.");
            }
        }
    }
}
}
