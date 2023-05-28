using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncycPlosh : MonoBehaviour
{
    [SerializeField] GameObject PloshchadInfo;
    public void OpenPloshchad()
    {
        if (GameEncyclopedia.PlochshadOpen)
        {
            PloshchadInfo.SetActive(true);
        }
    }
}
