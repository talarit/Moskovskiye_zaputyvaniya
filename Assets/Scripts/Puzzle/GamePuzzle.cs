using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePuzzle : MonoBehaviour
{
    public static int scorePuzzle;
    public static int progressPuzzle;
    [SerializeField] private GameObject MenuUi;
    [SerializeField] private Text textMainSc;
    [SerializeField] private Text textPz;
    // Start is called before the first frame update
    void Start()
    {
        scorePuzzle = 0;
        progressPuzzle = 0;
        MenuUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        textPz.text = $"{progressPuzzle}";
        textMainSc.text = $"{scorePuzzle}";
        if (progressPuzzle >=28)
        {
            scorePuzzle = 1000;
            MenuUi.SetActive(true);
            GameEncyclopedia.MGUopen = true;
        }
    }
}
