using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(0.0f, 0.5f, 0.0f);
        if(transform.position.y > 26.0f)
        {
            Destroy(gameObject);
        }
    }
}
