using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Point : MonoBehaviour
{
    public int NbPoint = 0;

    private void Update()
    {
        Debug.Log(NbPoint);
    }

    public void removePoint()
    {
        NbPoint--;
    }

    public void addPoint()
    {
        NbPoint++;
    }
}
