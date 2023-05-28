using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressButF : MonoBehaviour, IPointerClickHandler
{
    public GameObject _this;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            GameF.num1 = _this.tag;
        }
    }
}
