using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle_check_skull_enable : MonoBehaviour
{
    public GameObject fingerObject;
    public GameObject circleObject;

    void OnMouseDown()
    {
        // Disable finger, enable circle
        if (fingerObject != null)
            fingerObject.SetActive(false);

        if (circleObject != null)
            circleObject.SetActive(true);
    }
}
