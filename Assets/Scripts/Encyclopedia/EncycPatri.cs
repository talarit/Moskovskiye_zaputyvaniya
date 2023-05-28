using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncycPatri : MonoBehaviour
{
    [SerializeField] GameObject PatriarshiInfo;
    public void OpenPatriarshi()
    {
        if (GameEncyclopedia.PatriarshiOpen)
        {
            PatriarshiInfo.SetActive(true);
        }
    }
}
