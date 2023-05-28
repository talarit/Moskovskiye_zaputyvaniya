using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartF : MonoBehaviour
{
    [SerializeField] private GameObject MenuUi;


    public void Restarts()
    {
        MenuUi.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameF.score = 0;
    }
}
