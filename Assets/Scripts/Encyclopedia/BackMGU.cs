using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMGU : MonoBehaviour
{
    [SerializeField] GameObject MGUInfo;
    public void OpenMGU()
    {

            MGUInfo.SetActive(false);
    }
}
