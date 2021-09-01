using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public float tempsSpawnCible;
    public GameObject Cible;

    private float tempsAvantSpawn;

    void Start()
    {
        tempsAvantSpawn = Time.time + tempsSpawnCible;   
    }

    void Update()
    {
        if (tempsAvantSpawn < Time.time)
        {
            FaireSpawner();
        }
    }

    private void FaireSpawner()
    {
        tempsAvantSpawn = Time.time + tempsSpawnCible;
        var position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), -9f);
        Instantiate(Cible, position, Quaternion.identity);
    }
}
