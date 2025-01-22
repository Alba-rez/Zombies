using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        gameObject.SetActive(false);
    }
}
