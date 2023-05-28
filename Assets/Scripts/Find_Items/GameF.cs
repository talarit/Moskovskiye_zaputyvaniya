using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameF : MonoBehaviour
{
    public static string num1 = "";
    private GameObject[] gos;
    public static int score = 0;
    public Text textSc;
    [SerializeField] private GameObject MenuUi;
    [SerializeField] private Text textMainSc;
    void Start()
    {
        MenuUi.SetActive(false);
        score = 0;
    }


    void Update()
    {
        textSc.text = $"{score}";
        textMainSc.text = $"{score}";
        if (num1 == "item1")
        {
            gos = GameObject.FindGameObjectsWithTag("item1");
            score+=100;
            foreach (GameObject go in gos)
            {
                Destroy(go);
            }
            num1 = "";
        }
        if (num1 == "item2")
        {
            gos = GameObject.FindGameObjectsWithTag("item2");
            score+=100;
            foreach (GameObject go in gos)
            {
                Destroy(go);
            }
            num1 = "";
        }
        if (num1 == "item3")
        {
            gos = GameObject.FindGameObjectsWithTag("item3");
            score+=100;
            foreach (GameObject go in gos)
            {
                Destroy(go);
            }
            num1 = "";
        }
        if (num1 == "item4")
        {
            gos = GameObject.FindGameObjectsWithTag("item4");
            score+=100;
            foreach (GameObject go in gos)
            {
                Destroy(go);
            }
            num1 = "";
        }
        if (num1 == "item5")
        {
            gos = GameObject.FindGameObjectsWithTag("item5");
            score+=100;
            foreach (GameObject go in gos)
            {
                Destroy(go);
            }
            num1 = "";
        }
        if (num1 == "item6")
        {
            gos = GameObject.FindGameObjectsWithTag("item6");
            score+=100;
            foreach (GameObject go in gos)
            {
                Destroy(go);
            }
            num1 = "";
        }

        if (score >= 600)
        {
            MenuUi.SetActive(true);
            GameEncyclopedia.PlochshadOpen = true;
        }
    }
}
