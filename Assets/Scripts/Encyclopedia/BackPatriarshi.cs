using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPatriarshi : MonoBehaviour
{
    [SerializeField] GameObject PatriarshiInfo;
    public void OpenPatriarshi()
    {

            PatriarshiInfo.SetActive(false);
    }
}
