using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombSpawner : MonoBehaviour
{
    [SerializeField] float spawnDelay;
    [SerializeField] int zombieMax;
    [SerializeField] GameObject zombie;
    int numZombies;
    void Start()
    {
        StartCoroutine("SpawnZombie");
    }


    IEnumerator SpawnZombie()
    {
        yield return new WaitForSeconds(spawnDelay * 2);

        while (numZombies < zombieMax)
        {
            Instantiate(zombie, transform.position, Quaternion.identity);
            ++numZombies;
            yield return new WaitForSeconds(spawnDelay);

        }
    }
}