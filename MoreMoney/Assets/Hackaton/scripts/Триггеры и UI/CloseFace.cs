using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFace : MonoBehaviour
{
    public GameObject Object;

    public void Close()
    {
        Object.SetActive(false);
    }
}
