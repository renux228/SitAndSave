using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObj : MonoBehaviour
{
    [TextArea(3, 3)]
    public string Nm;
   
    public Text names;
    public Image img;
    public Sprite Sprt;
    public Transform Point;
    public GameObject Panel;
    public BossClick BC;
    public WorkBase WB;
    public Text Kazna;
    public GameObject DistActiveObj;
    public GameObject ObjectPole;
    private void OnMouseDown()
    {
        names.text = Nm;
        img.sprite = Sprt;
        Panel.SetActive(true);
      
        if (WB.DistWork)
        {
            DistActiveObj.SetActive(true);
            ObjectPole.SetActive(false);
        }
        else
        {
            ObjectPole.SetActive(true);
            DistActiveObj.SetActive(false);
        }

    }
  
   
 

}
