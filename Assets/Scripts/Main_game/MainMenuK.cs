using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuK : MonoBehaviour
{
    public void OpenMainK()
    {
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }
}
