using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkBase : MonoBehaviour
{
    public bool DistWork;
    public BossClick BC;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        DistWork = BC.Dist;

    }
}
