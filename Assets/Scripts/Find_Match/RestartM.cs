using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartM : MonoBehaviour
{
    [SerializeField] private GameObject MenuUi;
    [SerializeField] private GameObject TimerText;
    [SerializeField] private GameObject TimerTextSc;

    public void Restarts()
    {
        Time.timeScale = 1f;
        MenuUi.SetActive(false);
        TimerText.SetActive(false);
        TimerTextSc.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameM.progress = 0;
        GameM.paranum = 0;
        GameM.scorePl = 0;
        GameM.split = 0;
        GameM.timerStart = true;
        GameM.timerStart1 = false;
        TimerM.minusscore = 1;
        GameM.bonus = 1;
    }


}
