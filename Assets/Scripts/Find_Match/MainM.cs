using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainM : MonoBehaviour
{
    public void OpenMain()
    {
        SceneManager.LoadScene("Menu",LoadSceneMode.Single);
    }
}
