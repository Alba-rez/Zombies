using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    const int HIT_TO_DIE = 3;
    int hitCount;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            ++hitCount;

            if (hitCount == HIT_TO_DIE)
            {
                Destroy(gameObject);
            }
        }
    }

}
