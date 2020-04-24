using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    private float inputHorizontal;
    private float inputVertical;
    private Rigidbody m_rigidbody;
    private Transform _trans;
    public string Zoom;
    public string Minus;
    void Start()
    {
        _trans = gameObject.GetComponent<Transform>();
        
    }
    void Awake()
    {
       
        m_rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        inputHorizontal = SimpleInput.GetAxis(horizontalAxis);
        inputVertical = SimpleInput.GetAxis(verticalAxis);
    }
    void FixedUpdate()
    {
        _trans.Translate(inputVertical, 0, -inputHorizontal);
        //m_rigidbody.AddRelativeForce(new Vector3(0f, 0f, inputVertical) * 20f);
        if (SimpleInput.GetButton(Zoom))
        {
            _trans.Translate(0, 2*Time.deltaTime, 0);
        }
        if (SimpleInput.GetButton(Minus))
        {
            _trans.Translate(0, -2 * Time.deltaTime, 0);
        }
        if (SimpleInput.GetButton("r0"))
        {
            _trans.Rotate(0, 20 * Time.deltaTime, 0);
        }
    }
}
