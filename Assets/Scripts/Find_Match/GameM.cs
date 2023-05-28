using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameM : MonoBehaviour
{
    //очки игрока
    public static int scorePl = 0;
    //номер хода
    public static int progress = 0;
    //количество угаданных пар
    public static int paranum = 0;
    //удвоение очков
    public static int split = 0;
    public Text textSc;

    public Text textPr;
    public Text textSp;
    public static int para;
    public static string num1 = "";
    public static string num2 = "";
    private GameObject[] gos;
    public static bool timerStart;
    public static bool timerStart1;
    public static int bonus = 1;
    [SerializeField] private GameObject MenuUi;
    [SerializeField] private GameObject TextWin;
    [SerializeField] private TimerM timer;
    [SerializeField] private GameObject TimerText;
    [SerializeField] private GameObject TimerTextSc;
    [SerializeField] private Text textMainSc;


    void Start()
    {
        MenuUi.SetActive(false);
        timerStart = true;
        timerStart1 = false;
        TimerText.SetActive(false);
        TimerTextSc.SetActive(false);
        Time.timeScale = 1f;
        progress = 0;
        paranum = 0;
        scorePl = 0;
        split = 0;
        TimerM.minusscore = 1;
        bonus = 1;
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
        //условие за каждое угадывание +1 очко
        int num3 = 0;
        foreach (GameObject go in gos)
        {
            num3++;
            if ((go != null) && (num3 == 6))
            {

                ScorePlus();
            }
            Destroy(go);
        }
    }

    void Update()
    {
        textSc.text = $"{scorePl}";
        textMainSc.text= $"{scorePl}";
        textPr.text = $"{progress}";
        if ((num1 == "one") && (num2 == "one"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("one");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "two") && (num2 == "two"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("two");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "three") && (num2 == "three"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("three");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "four") && (num2 == "four"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("four");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "five") && (num2 == "five"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("five");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "six") && (num2 == "six"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("six");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "seven") && (num2 == "seven"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("seven");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "eight") && (num2 == "eight"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("eight");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }
        if ((num1 == "nine") && (num2 == "nine"))
        {
            num1 = "";
            num2 = "";
            gos = GameObject.FindGameObjectsWithTag("nine");
            StartCoroutine(ExampleCoroutine());
            para = 0;
            split++;
        }

        if (paranum >= 9)
        {
            MenuUi.SetActive(true);
            TextWin.SetActive(true);
            GameEncyclopedia.PatriarshiOpen = true;
        }

        if (timerStart1 && timerStart)
        {
            timer.StartTime();
            TimerText.SetActive(true);
            TimerTextSc.SetActive(true);
        }
        if (bonus == 1)
        {
            textSp.text = "нет";
        } else
        {
            textSp.text = $"{bonus}";
        }
    

    }

    public static void ClickPar()
    {
        para++;
    }


    public void ScorePlus()
    {
        if ((split >= 2) && (split % 2 == 0))
        {
            bonus++;
            scorePl += 100 * bonus;
        }
        else
        {
            scorePl += 100;
        }
        paranum++;
    }
}
