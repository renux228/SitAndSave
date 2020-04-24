using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossClick : MonoBehaviour
{
    public int Energy;
    public bool Quarantine;
    public int ZP;
    public int CEN;
    public bool Dist;
    public GameObject POLE;
    public GameObject POLESUPP;
    public int SupportMoney;
    public GameObject AdminPan;
    public GameObject AnimKar;
    public GameObject Samolet;
    public Text EnergyText;
    
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        AdminPan.SetActive(true);
    }

    public void Supp()
    {
        if (Energy >= 1000)
        {
            Energy -= 1000;
            SupportMoney = 50;
            POLESUPP.SetActive(false);
        }
       
    }

    public void KarantineActive()
    {
        if (Quarantine)
        {
            Quarantine = false;
            AnimKar.SetActive(false);
            Samolet.SetActive(false);
        }
        else
        {
            Quarantine = true;
            AnimKar.SetActive(true);
            Samolet.SetActive(true);
        }
    }
    void Update()
    {
        EnergyText.text = Energy.ToString();
        
    }
    public void DistActive()
    {
        if (Energy >= 500)
        {
            POLE.SetActive(false);
            Dist = true;
            Energy -= 500;
        }
       
    }
}
