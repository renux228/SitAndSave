using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookiShop : MonoBehaviour
{
    public Stat St;
    public HomeScript HS;
    public BossClick BC;

    public bool GoToHome;

    public int _num;
    public int Speed;
    private Transform _body;
    public Transform[] _transforms;
    private Vector3 _rot;
   
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        St = gameObject.GetComponent<Stat>();
        HS= gameObject.GetComponent<HomeScript>();

    }

    public void Randomer()
    {
        //_num = Random.Range(0, _transforms.Length);

    }
    void Update()
    {


        if (_num < _transforms.Length)
        {
           
            _body.position = Vector3.MoveTowards(_body.position, _transforms[_num].position, Speed * Time.deltaTime);
            _rot = new Vector3(_transforms[_num].position.x, _body.position.y, _transforms[_num].position.z);
            _body.LookAt(_rot);
        }
        else
        {
           
            SaleProdukt();
            return;
        }

        if (Vector3.Distance(_body.position, _transforms[_num].position) < 0.2f)
        {

            _num += 1;



        }
    }
    public void SaleProdukt()
    {
        if (St.Money >= 1)
        {
            HS.Produkt = true;
            HS.Pocket.SetActive(true);
            HS._num = 0;
            
            St.Money -= 1;
            St.Timers = 0;
        }
        else
        {
            HS.Produkt = true;
            HS.Pocket.SetActive(true);
            HS._num = 0;
            St.Virus += 5;
            St.Timers = 0;
        }
        
        _num = 0;
       
    }
}
