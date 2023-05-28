using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EncyclopediaMenu : MonoBehaviour
{
    public void OpenEncyclopediaMenu()
    {
        SceneManager.LoadScene("Encyclopedia", LoadSceneMode.Single);
    }
}
