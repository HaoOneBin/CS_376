using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Vector2 mouseStartPos, mouseEndPos;
    Rigidbody2D playerRB2D;
    public float force = 2;
    public Vector2 minForce, maxForce;
    public float moveSpeed = 5;

    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        playerRB2D.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);

    }
}
