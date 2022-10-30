using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    public GameObject food;
    public GameObject dog;
    public GameObject catNormal;
    public GameObject replayBtn;

    public Text txtLevel;
    public GameObject barFrontLevel;

    int level = 0;
    int cat = 0;

    private void Awake()
    {
        GM = this;
    }

    void Start()
    {
        InvokeRepeating("makeFood", 0.0f, 0.1f);
        InvokeRepeating("makeCat", 0.0f, 1.0f);
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

    void makeCat()
    {
        Instantiate(catNormal);
        if(level == 1)
        {
            float p = Random.Range(0, 10);
            if (p < 2) Instantiate(catNormal);
        }
        if (level >= 2)
        {
            float p = Random.Range(0, 10);
            if (p < 5) Instantiate(catNormal);
        }
    }

    public void gameOver()
    {
        replayBtn.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void addCat()
    {
        cat += 1;
        level = cat / 5;
        txtLevel.text = level.ToString();
        barFrontLevel.transform.localScale = new Vector3((cat - level * 5) / 5.0f, 1.0f, 1.0f);
    }
}
