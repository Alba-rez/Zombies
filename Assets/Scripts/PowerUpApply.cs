using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpApply : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    const int POWER = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("ApplyDamage", -POWER);
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
