using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject MenuUi;
    public void RestartPuz()
    {
        MenuUi.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GamePuzzle.progressPuzzle = 0;
        GamePuzzle.scorePuzzle = 0;
    }
}