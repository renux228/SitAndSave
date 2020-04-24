using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMans : MonoBehaviour
{
    [TextArea(3, 3)]
    public string Nm;

    public Text names;
    public Image img;
    public Text eatText;
    public Text MoneyText;
    
    public Sprite Sprt;
    public Transform Point;
    public GameObject Panel;
    public Stat st;
    private void OnMouseDown()
    {
        eatText.text = st.Hunger.ToString();
        MoneyText.text = st.Money.ToString();
        names.text = Nm;
        img.sprite = Sprt;
        Panel.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
