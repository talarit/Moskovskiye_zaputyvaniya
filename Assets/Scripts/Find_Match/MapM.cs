using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapM : MonoBehaviour
{
    public void OpenMap()
    {
        SceneManager.LoadScene("Main_game",LoadSceneMode.Single);
    }
}
