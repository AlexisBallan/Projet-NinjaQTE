using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToucherCible : MonoBehaviour
{

    private void OnMouseEnter()
    {
        GameObject.Find("Spawner").GetComponent<Point>()?.addPoint();
        Destroy(gameObject);
    }
}
