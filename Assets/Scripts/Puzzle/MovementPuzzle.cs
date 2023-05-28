using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementPuzzle : MonoBehaviour
{
    public bool move;
    Vector2 coordMouse;
    float coordX;
    float coordY;
    [SerializeField] GameObject obj;
    [SerializeField] Image objFin;
    [SerializeField] Image Im1;



    private void OnMouseDown()
    {
        if(Input.GetMouseButton(0))
        {
            move = true;
            coordX = obj.transform.localPosition.x;
            coordY =  obj.transform.localPosition.y;
        }
    }

    private void OnMouseUp()
    {
        move = false;
        if (Mathf.Abs(this.transform.localPosition.x - objFin.transform.localPosition.x) <=10f && Mathf.Abs(this.transform.localPosition.y - objFin.transform.localPosition.y) <= 10f) 
        {
            GamePuzzle.progressPuzzle++;
            objFin.color = new Color(1f, 1f, 1f, 1f);
            Im1.enabled = false;
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Im1.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(move)

        {
            coordMouse.x = Input.mousePosition.x - Screen.width/2;
            coordMouse.y = Input.mousePosition.y - Screen.height / 2;
            this.gameObject.transform.localPosition = new Vector2(coordMouse.x - coordX, coordMouse.y-coordY);
        }
    }
}
