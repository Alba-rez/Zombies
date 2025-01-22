using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] float delay;

    GameObject powerUp=null;
    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            if (powerUp == null)
            {
                yield return new WaitForSeconds(delay);
                Vector3 position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
                    powerUp = Instantiate(prefab,position, Quaternion.identity);
            }
            yield return new WaitForSeconds(0.5f);
        }

    }
}
