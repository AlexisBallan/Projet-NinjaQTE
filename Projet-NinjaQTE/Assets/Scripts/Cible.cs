using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cible : MonoBehaviour
{
    private float tempsAvantDisparition;
    private Vector3 scaleChange;

    public float tempsRestant;


    void Start()
    {
        tempsAvantDisparition = Time.time + tempsRestant;
        scaleChange = new Vector3(-0.002f, -0.002f, -0.002f);
    }

    void Update()
    {
        if (tempsAvantDisparition < Time.time)
            Fail();
    }

    private void FixedUpdate()
    {
        // gameObject.transform.localScale = new Vector3(-0.001f, -0.001f, -0.001f);
        gameObject.transform.localScale += scaleChange;
    }

    private void Fail()
    {
        GameObject.Find("Spawner").GetComponent<Point>()?.removePoint();
        Destroy(gameObject);
    }
}
