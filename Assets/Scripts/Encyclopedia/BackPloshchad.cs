using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPloshchad : MonoBehaviour
{
    [SerializeField] GameObject PloshchadInfo;
    public void OpenPloshchad()
    {
            PloshchadInfo.SetActive(false);

    }
}
