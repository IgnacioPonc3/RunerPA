using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawner;

    void Start()
    {
        InvokeRepeating("SpawnCactus", 0, 5f);
    }

    public void SpawnCactus()
    {
        GameObject cactus =  ObjectPool.SharedInstance.GetPooledObject();
        if (cactus != null)
        {
            cactus.transform.position = spawner.transform.position;
            cactus.transform.rotation = spawner.transform.rotation;
            cactus.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
