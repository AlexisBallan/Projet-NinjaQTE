using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucherCible : MonoBehaviour
{
    public GameObject Point;

    private void OnMouseEnter()
    {
        Point.GetComponent<Point>()?.addPoint();
        Destroy(gameObject);
    }
}
