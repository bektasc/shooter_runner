using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed;
    private float horizontalSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        moveSpeed = 500f;
        horizontalSpeed = 10f;
    }

    private void Update()
    {
        Vector3 movement;
        movement = new Vector3(Input.GetAxis("Horizontal") * horizontalSpeed, 0, (Time.fixedDeltaTime * moveSpeed));
        rb.velocity = movement;
    }
}
