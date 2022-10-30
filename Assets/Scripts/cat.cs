using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    float full = 5.0f;
    float energy = 0.0f;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            if(energy < full)
            {
                energy += 1.0f;
                Destroy(collision.gameObject);
                gameObject.transform.Find("hungry/Canvas/bar_front").transform.localScale = new Vector3(energy / full, 1.0f, 1.0f);
            }
            else
            {
                gameObject.transform.Find("hungry").gameObject.SetActive(false);
                gameObject.transform.Find("full").gameObject.SetActive(true);
            }
        }
    }
}
