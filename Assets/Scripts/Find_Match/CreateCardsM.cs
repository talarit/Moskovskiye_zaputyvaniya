using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreateCardsM : MonoBehaviour
{
    //колода карт
    [SerializeField] private GameObject[] cards;
    //переменная - карта
    private GameObject card;
    List<int> ns = new List<int>();
    private int n;
    private bool stak = false;
    private bool r = false;
    void Start()
    {
        for (int i = 0; i < 18; i++)
        {
            stak = true;
            card = cards[i];
            while (stak)
            {
                n = Random.Range(1, 19);
                r = ns.Contains(n);
                if (!r)
                {
                    switch (n)
                    {
                        case 1:
                            ns.Add(1);
                            stak = false;
                            r = false;
                            GameObject carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(600f, 20f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            /*  var ratr = carz.transform as RectTransform;
                              Debug.Log(ratr.rect.width);
                              Debug.Log(ratr.rect.height); */
                            break;
                        case 2:
                            ns.Add(2);
                            stak = false;
                            r = false;
                            carz = Instantiate(card, new Vector2(20f, 20f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(360f, 20f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            break;
                        case 3:
                            ns.Add(3);
                            stak = false;
                            r = false;
                            carz = Instantiate(card, new Vector2(30f, 30f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(120f, 20f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            break;
                        case 4:
                            ns.Add(4);
                            stak = false;
                            r = false;
                            carz = Instantiate(card, new Vector2(0f, 0f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-120f, 20f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            break;
                        case 5:
                            ns.Add(5);
                            stak = false;
                            r = false;
                            carz = Instantiate(card, new Vector2(-10f, -10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-360f, 20f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            break;
                        case 6:
                            ns.Add(6);
                            carz = Instantiate(card, new Vector2(-20f, -20f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-600f, 20f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            r = false;
                            break;
                        case 7:
                            ns.Add(7);
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(600f, 310f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            r = false;
                            break;
                        case 8:
                            ns.Add(8);
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(360f, 310f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            r = false;
                            break;
                        case 9:
                            ns.Add(9);
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(120f, 310f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            r = false;
                            break;
                        case 10:
                            ns.Add(10);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-120f, 310f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 11:
                            ns.Add(11);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-360f, 310f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 12:
                            ns.Add(12);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-600f, 310f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 13:
                            ns.Add(13);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-600f, -270f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 14:
                            ns.Add(14);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-360f, -270f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 15:
                            ns.Add(15);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(-120f, -270f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 16:
                            ns.Add(16);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(120f, -270f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 17:
                            ns.Add(17);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(360f, -270f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                        case 18:
                            ns.Add(18);
                            r = false;
                            carz = Instantiate(card, new Vector2(10f, 10f), Quaternion.identity) as GameObject;
                            carz.transform.SetParent(GameObject.FindGameObjectWithTag("Canvaz").transform, false);
                            carz.transform.localPosition = new Vector2(600f, -270f);
                            carz.transform.localScale = new Vector2(0.1f, 0.25f);
                            stak = false;
                            break;
                    }
                }
            }
        }


    }

}
