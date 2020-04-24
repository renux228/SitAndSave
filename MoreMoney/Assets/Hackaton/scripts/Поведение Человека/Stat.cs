using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{

   
    public int Hp;
    public bool TestScript;
    public float Hunger;
    public int Money;
    public int Virus;
    public bool Home;
    public bool Worker;
    public bool WorkInKarantin;
    public float Timers;
    public bool Kostl;
    public bool TsT;
    public GoToEat GE;
    public MoveMan Mv;
    public HomeScript HS;
    public MedicHelp MH;
    public BossClick BC;
    public WorkScript WS;
    public GameObject Mask;
    public SpookiShop SS;
    public WorkBase WB;

    void Start()
    {
        Mv.enabled = false;
        SS = gameObject.GetComponent<SpookiShop>();
        WS = gameObject.GetComponent<WorkScript>();
    }

   
    void Update()
    {
        if (!BC.Quarantine)
        {
            if (!WorkInKarantin)
            {
                Mask.SetActive(false);
            }
            
            if (Virus > 20)
            {
                MH.enabled = true;
                HS.enabled = false;
                Mv.enabled = false;
                GE.enabled = false;
            }
            else
            {
                if (MH.enabled == false)
                {
                    MH.Call = true;
                }
                //MH.Call = false;
                Timers -= 1f * Time.deltaTime;
                if (Timers <= 0)
                {
                    TakeHunger();

                }
            }

        }
        else
        {
            if (!WorkInKarantin)
            {


                Mask.SetActive(true);
            }

            if (Virus > 20)
            {
                MH.enabled = true;
                HS.enabled = false;
                Mv.enabled = false;
                GE.enabled = false;
            }
            else
            {
                if (MH.enabled == false)
                {
                    MH.Call = true;
                }
                //MH.Call = false;
                Timers -= 1f * Time.deltaTime;
                if (Timers <= 0)
                {
                    Karantin();

                }
            }
          
        }
        
       
        
        
        
    }
    public void HelpMedic()
    {

    }
    public void Karantin()
    {
        Timers = 5;
        Hunger -= 10;
        if (!Worker)
        {
            Money += BC.SupportMoney;
        }
        else
        {
            if (WB.DistWork&&!WorkInKarantin)
            {
                Money += 10;
            }
           
        }
        if (Money <= 100 &&(Worker)&&(WorkInKarantin)&&(Hunger>50))
        {
            WS.enabled = true;
            return;
            
        }
        if (Hunger < 80)
        {
            if (HS.Produkt)
            {
                MH.enabled = false;
                if (WS != false)
                {
                    WS.enabled = false;
                }
                HS.enabled = true;
                Mv.enabled = false;
                GE.enabled = false;
               
                if (TsT)
                    SS.enabled = false;
                return;
            }
            else
            {
                MH.enabled = false;
                HS.enabled = false;
                if (WS != false)
                {
                    WS.enabled = false;
                }
                Mv.enabled = false;
                if (Money >= BC.CEN)
                {
                    GE.enabled = true;
                }
                else
                {
                    if (TsT)
                    {
                        SS.enabled = true;
                    }
                }

            }
               
        }
        else
        {
            if (TsT)
            {
                SS.enabled = false;
            }
            MH.enabled = false;
            HS.enabled = true;
            Mv.enabled = false;
            GE.enabled = false;
            
            if (WS != false)
            {
                WS.enabled = false;
            }
        }

    }

    public void TakeHunger()
    {
        Timers = 10;
        Hunger -= 5;
       
        
     
        if (HS.Produkt)
        {
            MH.enabled = false;
            HS.enabled = true;
            GE.enabled = false;
            if (WS != false)
            {
                WS.enabled = false;
            }
            if (TsT)
            SS.enabled = false;
            return;
        }
        if (Hunger < 80)
        {
            if (HS.Produkt)
            {
                MH.enabled = false;
                HS.enabled = true;
                Mv.enabled = false;
                GE.enabled = false;
                if (WS != false)
                {
                    WS.enabled = false;
                }
                if (TsT)
                {
                    SS.enabled = false;
                }
               
            }
           else
            {
                MH.enabled = false;
                HS.enabled = false;
                Mv.enabled = false;
                if (Money >= BC.CEN)
                {
                    GE.enabled = true;
                    if (WS != false)
                    {
                        WS.enabled = false;
                    }
                }
                else
                {
                    if (TsT)
                    {
                        SS.enabled = true;
                    }
                    if (WS != false)
                    {
                        WS.enabled = false;
                    }
                }
                
               
                
            }

        }
        else
        {
            if (TsT)
            {
                SS.enabled = false;
            }
            MH.enabled = false;
            HS.enabled = false;
            if (Money <= 100 && (Worker))
            {

                WS.enabled = true;
                return;
            }
            GE.enabled = false;
            if (WS != false)
            {
                WS.enabled = false;
            }
        }
    }
}
