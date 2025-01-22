using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] Animator anim;
    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.tag =="Player")
        {
            anim.SetTrigger("Open");
        }
    }
}
