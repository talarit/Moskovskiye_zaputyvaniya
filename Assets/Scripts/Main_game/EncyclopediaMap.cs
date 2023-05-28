using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EncyclopediaMap : MonoBehaviour
{
    public void OpenEncyclopediaMap()
    {
        SceneManager.LoadScene("Encyclopedia", LoadSceneMode.Single);
    }
}
