using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMan : MonoBehaviour
{
    public int _num;
    public int Speed;
    private Transform _body;
    private Vector3 _rot;
    public Transform[] _transforms;
    public Animator An;
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
        
        if (_num < _transforms.Length)
        {
            An.enabled = true;
            _body.position = Vector3.MoveTowards(_body.position, _transforms[_num].position, Speed * Time.deltaTime);
            _rot = new Vector3(_transforms[_num].position.x, _body.position.y, _transforms[_num].position.z);
            _body.LookAt(_rot);
   
        }
        else
        {
            _num = 0;
            An.enabled = false;
        }
        
        if (Vector3.Distance(_body.position, _transforms[_num].position) < 0.2f)
        {
            
                _num += 1;
          
          
            
        }
    }
}
