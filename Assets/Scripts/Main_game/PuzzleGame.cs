using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleGame : MonoBehaviour
{
    public void OpenPuzzle()
    {
        SceneManager.LoadScene("Puzzle");
    }
}
