using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    const float CLAMP_MIN = -45;
    const float CLAMP_MAX = 45;
    GameObject player;
    float lookSensitivity = 2;
    Vector2 rotation = Vector2.zero;
    Vector2 smoothRot = Vector2.zero;
    Vector2 velRot = Vector2.zero;
    void Start()
    {
        player = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // giro de la cabeza derecha/izquierda

        player.transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X")* lookSensitivity);

        // giro up/down de la cabeza 

        rotation.y += Input.GetAxis("Mouse Y");
        rotation.y = Mathf.Clamp(rotation.y, CLAMP_MIN, CLAMP_MAX);
        smoothRot.y=Mathf.SmoothDamp(smoothRot.y, rotation.y, ref velRot.y,0.1f);
        transform.localEulerAngles = new Vector3(-smoothRot.y, 0, 0);
    }
}
