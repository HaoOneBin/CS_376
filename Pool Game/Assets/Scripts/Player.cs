using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private AudioSource myAudioSource;
    public AudioClip hit;

    Vector2 mouseStartPos, mouseEndPos;
    Rigidbody2D playerRB2D;
    public float force = 2;
    public Vector2 minForce, maxForce;
    public float moveSpeed = 5;    

    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
        myAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        playerRB2D.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Ball_1" ||
            collision.collider.name == "Ball_2" ||
            collision.collider.name == "Ball_3" ||
            collision.collider.name == "Ball_4" ||
            collision.collider.name == "Ball_5" ||
            collision.collider.name == "Ball_6")
        {
            myAudioSource.PlayOneShot(hit);
        }

    }
}
