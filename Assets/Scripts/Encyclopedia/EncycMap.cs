using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EncycMap : MonoBehaviour
{
    public void OpenEncycMap()
    {
        SceneManager.LoadScene("Main_game", LoadSceneMode.Single);
    }
}
