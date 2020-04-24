using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkScript : MonoBehaviour
{
    public int _num;
    public int Speed;
    private Transform _body;
    private Vector3 _rot;
    public Transform[] _transforms;
    public float WorkTime;
    public float EndWorkTime;
    public Stat st;
    public BossClick BC;
    void Start()
    {
        _body = gameObject.GetComponent<Transform>();
        st = gameObject.GetComponent<Stat>();
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
            WorkTime -= 1f*Time.deltaTime;
            if (WorkTime <= 0)
            {
                st.Money += BC.ZP+1;
                BC.Energy += 100;
                WorkTime = EndWorkTime;
                _num = 0;
                st.Timers = 0;
                
            }
            return;
        }

        if (Vector3.Distance(_body.position, _transforms[_num].position) < 0.2f)
        {

            _num += 1;



        }
    }
}
