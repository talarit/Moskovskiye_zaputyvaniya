using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuM : MonoBehaviour
{
    public GameObject MenuUI;
    public GameObject TextWin;
    private GameObject[] gos1;

    public void Pausemenu()
    {
        TextWin.SetActive(false);
        gos1 = GameObject.FindGameObjectsWithTag("one");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("two");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("three");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("four");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("five");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("six");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("seven");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("eight");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        gos1 = GameObject.FindGameObjectsWithTag("nine");
        foreach (GameObject go in gos1)
        {
            Destroy(go);
        }
        Time.timeScale = 0f;
        MenuUI.SetActive(true);


    }

    public void Resumemenu()
    {
        Time.timeScale = 1f;
        MenuUI.SetActive(false);
    }

}
