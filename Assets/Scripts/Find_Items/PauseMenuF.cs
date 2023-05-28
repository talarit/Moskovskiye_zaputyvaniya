using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuF : MonoBehaviour
{
    public GameObject MenuUI;
    public GameObject TextWin;

    public void Pausemenu()
    {
        TextWin.SetActive(false);    
        Time.timeScale = 0f;
        MenuUI.SetActive(true);


    }

    public void Resumemenu()
    {
        Time.timeScale = 1f;
        MenuUI.SetActive(false);
    }

}
