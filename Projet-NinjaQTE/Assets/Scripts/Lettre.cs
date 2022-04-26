using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Lettre : MonoBehaviour
{

    public Text text;
    private float tempsEntreLettre = 3;

    private float tempsRestant;
    private string newLetter = "A";
    private string toucheAppuyer;
    private bool toucher = false;
    private string[] randomQTE = new string[4]
    {
        "A", "W", "S", "D"
    };

    void Start()
    {
        tempsRestant = Time.time + tempsEntreLettre;
    }

    

    void FixedUpdate()
    {
        text.text = newLetter;

        if (tempsRestant < Time.time)
        {
            if (toucher == true)
            {
                toucher = false;
                generateNewLetter();
            }
            else
            {
                failTouche();
                generateNewLetter();
            }
           
        }



        foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                toucheAppuyer = Convert.ToString(kcode);
                verif();
            }
        }

    }

    private void verif()
    {
        if (toucheAppuyer == newLetter)
        {
            validerTouche();
            toucher = true;
        }
        else
        {
            failTouche();
        }
    }

    private void failTouche()
    {
        tempsRestant = Time.time + tempsEntreLettre;
        GameObject.Find("Spawner").GetComponent<Point>()?.removePoint();
        Debug.Log("Fail");
        newLetter = " ";
    }

    private void validerTouche()
    {
        GameObject.Find("Spawner").GetComponent<Point>()?.addPoint();
        Debug.Log("Lettre fonctionne");
        newLetter = " ";
    }
    private void generateNewLetter()
    {
        newLetter = randomQTE[UnityEngine.Random.Range(0, randomQTE.Length)];

    }
}
