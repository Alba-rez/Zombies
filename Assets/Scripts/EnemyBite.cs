using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBite : MonoBehaviour
{
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("ApplyDamage", 1);
        }
        
    }
}
