using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject food;
    public GameObject dog;

    void Start()
    {
        InvokeRepeating("makeFood", 0.0f, 0.2f);
    }

    void Update()
    {
        
    }

    void makeFood()
    {
        float posX = dog.transform.position.x;
        float posY = dog.transform.position.y;
        Instantiate(food, new Vector3(posX, posY, 0), Quaternion.identity);
    }
}
