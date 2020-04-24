using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicHelp : MonoBehaviour
{
    private Transform _body;
    public Transform Hospital;
    public float Speed;
    public Transform Car;
    public bool Call;
    public float TimerS;
    public float MaxTime;
  
    public Stat st;
    private Vector3 _rot;
    public SpookiShop ss;
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        ss = gameObject.GetComponent<SpookiShop>();
    }

    
    void Update()
    {
        if (Call)
        {
            
            Car.gameObject.SetActive(true);
            Car.position = Vector3.MoveTowards(Car.position, _body.position,Speed*Time.deltaTime);
            _rot = new Vector3(_body.position.x, Car.position.y, _body.position.z);
            Car.LookAt(_rot);
            if (Vector3.Distance(Car.position, _body.position) < 0.2f)
            {
                ss.enabled = false;
                Call = false;
            }
        }
        else
        {
            Car.position = Vector3.MoveTowards(Car.position, Hospital.position, Speed * Time.deltaTime);
            _rot = new Vector3(Hospital.position.x, Car.position.y, Hospital.position.z);
            Car.LookAt(_rot);
            _body.position = Car.position;
            if (Vector3.Distance(Car.position, Hospital.position) < 0.2f)
            {
                Car.gameObject.SetActive(false);
                TimerS -= 1f * Time.deltaTime;
                if (TimerS <= 0)
                {
                    TikeMedkit();
                }
                
            }
        }
    }
    public void TikeMedkit()
    {
        if (st.Virus > 0)
        {
            TimerS = MaxTime;
            st.Virus -= 1;
            st.Hunger += 10;
        }
        else
        {
            st.MH.enabled = false;
        }
        
    }
}
