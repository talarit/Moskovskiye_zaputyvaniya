using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncycMGU : MonoBehaviour
{
    [SerializeField] GameObject MGUInfo;
    public void OpenMGU()
    {
        if (GameEncyclopedia.MGUopen)
        {
            MGUInfo.SetActive(true);
        }
    }
}
