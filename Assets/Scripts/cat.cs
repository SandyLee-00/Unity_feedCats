using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    void Start()
    {
        float posX = Random.Range(-8.5f, 8.5f);
        float posY = 30.0f;
        transform.position = new Vector3(posX, posY, 0);
    }

    void Update()
    {
        transform.position += new Vector3(0.0f, -0.05f, 0.0f);
    }
}
