using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mousePosX = mousePos.x;
        if (mousePosX > 9.5f) mousePosX = 9.5f;
        else if (mousePosX < -9.5f) mousePosX = -9.5f;
        transform.position = new Vector3(mousePosX, transform.position.y, 0);
    }
}
