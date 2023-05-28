using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapPuzzle : MonoBehaviour
{
    public void OpenMapPuz()
    {
        SceneManager.LoadScene("Main_game", LoadSceneMode.Single);
    }
}
