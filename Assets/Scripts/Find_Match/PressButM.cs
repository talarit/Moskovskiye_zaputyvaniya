using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PressButM : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject part1;
    [SerializeField] private GameObject part2;
    public GameObject _this;
    private bool proverka = true;

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
        part1.transform.SetSiblingIndex(1);
        part2.transform.SetSiblingIndex(0);
        proverka = true;
        GameM.para = 0;
    }
    IEnumerator StartsCoroutine()
    {
        yield return new WaitForSeconds(4f);
        part1.transform.SetSiblingIndex(1);
        part2.transform.SetSiblingIndex(0);
    }
    public void Start()
    {
        StartCoroutine(StartsCoroutine());
    }
    public void Update()
    {
        if (GameM.para == 2)
        {
            proverka = false;
            StartCoroutine(ExampleCoroutine());
            GameM.num1 = "";
            GameM.num2 = "";
        }
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if ((GameM.para == 1) && (proverka))
            {
                part1.transform.SetSiblingIndex(0);
                part2.transform.SetSiblingIndex(1);
                GameM.ClickPar();
                GameM.num2 = _this.tag;
                GameM.progress++;
                if ((GameM.num1 != GameM.num2))
                {
                    GameM.bonus = 1;
                    GameM.split = 1;
                    //уменьшение очков при неправильном ходе
                    if (GameM.scorePl > 25)
                    {
                        GameM.scorePl -= 25;
                    }
                    else
                    {
                        GameM.scorePl = 0;
                    }
                    GameM.num1 = "";
                    GameM.num2 = "";
                    proverka = false;
                    StartCoroutine(ExampleCoroutine());
                }
            }
            if ((GameM.para == 0) && (proverka))
            {
                if (GameM.timerStart)
                {
                    GameM.timerStart1 = true;
                }
                part1.transform.SetSiblingIndex(0);
                part2.transform.SetSiblingIndex(1);
                GameM.ClickPar();
                GameM.num1 = _this.tag;
            }
        }
    }
}
