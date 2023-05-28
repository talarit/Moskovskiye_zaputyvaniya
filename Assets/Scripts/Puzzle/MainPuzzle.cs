using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPuzzle : MonoBehaviour
{
    public void OpenMainPuz()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
