using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    public bool Produkt;
    public GameObject Pocket;
    
    public Stat st;
    public int _num;
    public int Speed;
    public float Timers;
    public float MaxTimers;
    private Transform _body;
    public Transform[] _transforms;
    private Vector3 _rot;
  
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
    }

    public void Randomer()
    {
        //_num = Random.Range(0, _transforms.Length);

    }
    void Update()
    {
      
        if (Produkt)
        {
            Pocket.SetActive(true);
            if (_num < _transforms.Length)
            {
             
                _body.position = Vector3.MoveTowards(_body.position, _transforms[_num].position, Speed * Time.deltaTime);
                _rot = new Vector3(_transforms[_num].position.x, _body.position.y, _transforms[_num].position.z);
                _body.LookAt(_rot);
            }
            else
            {
              
                Timers -= 1f * Time.deltaTime;
                if (Timers <= 0)
                {
                    st.Hunger = 100;
                    Timers = MaxTimers;
                    Produkt = false;
                   
                    
                }
                return;
            }

            if (Vector3.Distance(_body.position, _transforms[_num].position) < 0.2f)
            {

                _num += 1;
            }

        }
        else
        {
            Pocket.SetActive(false);
        }
       
    }
}
