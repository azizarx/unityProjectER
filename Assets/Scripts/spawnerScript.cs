using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public Vector3[] spawnPoints;
    public float spawnTime;
    private float cooldown;
    public GameObject obstacle;
 


    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            spawn();
            cooldown = spawnTime;
        }
    }

    void spawn()
    {
        int i= Random.Range(0, spawnPoints.Length);
        Instantiate(obstacle, spawnPoints[i], Quaternion.identity);
    }
}
