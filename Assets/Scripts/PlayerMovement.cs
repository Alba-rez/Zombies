using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Rigidbody rb;
    CapsuleCollider col;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb=GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = Vector2.zero;
        moveInput.x = Input.GetAxis("Horizontal") * speed;
        moveInput.y = Input.GetAxis("Vertical") * speed;
        moveInput *= Time.deltaTime;
        transform.Translate(moveInput.x, 0, moveInput.y);

        // salto
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        

        // liberar al ratón 

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}
