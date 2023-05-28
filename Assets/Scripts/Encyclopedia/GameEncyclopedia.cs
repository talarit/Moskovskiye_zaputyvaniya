using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEncyclopedia : MonoBehaviour
{
    [SerializeField] GameObject MenuMGU;
    [SerializeField] GameObject MenuPlochshad;
    [SerializeField] GameObject MenuPatriarshi;
    public static bool MGUopen;
    public static bool PlochshadOpen;
    public static bool PatriarshiOpen;
    public Sprite OpenMGU;
    public Sprite OpenPloshchad;
    public Sprite OpenPatriarshi;
    public Button ButtonMGU;
    public Button ButtonPloshchad;
    public Button ButtonPatriarshi;
    // Start is called before the first frame update
    void Start()
    {
        MenuMGU.SetActive(false);
        MenuPatriarshi.SetActive(false);
        MenuPlochshad.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MGUopen)
        {
            ButtonMGU.image.sprite = OpenMGU;
        }
        if (PatriarshiOpen)
        {
            ButtonPatriarshi.image.sprite = OpenPatriarshi;
        }
        if (PlochshadOpen)
        {
            ButtonPloshchad.image.sprite = OpenPloshchad;
        }
    }
}
