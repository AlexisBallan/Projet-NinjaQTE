using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lettre : MonoBehaviour
{

    public string newLetter;
    public Text text;
    public float tempsEntreLettre;

    private float tempsRestant;
    private string[] randomQTE = new string[4]
    {
        "A", "W", "S", "D"
    };

    private void Start()
    {
        tempsRestant = Time.time + tempsEntreLettre;
    }

    private void Update()
    {
        if (tempsRestant < Time.time)
        {
            failTouche();

            generateNewLetter();

        }

        if (Input.GetKeyDown(newLetter))
            validerTouche();
    }

    private void failTouche()
    {
        GameObject.Find("Spawner").GetComponent<Point>()?.removePoint();
    }

    private void validerTouche()
    {
        GameObject.Find("Spawner").GetComponent<Point>()?.addPoint();
        Debug.Log("Lettre fonctionne");
    }
    private void generateNewLetter()
    {
        newLetter = randomQTE[Random.Range(0, randomQTE.Length)];

        text.text = newLetter;
    }
}
