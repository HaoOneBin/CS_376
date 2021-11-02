using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject BulletPrefab;

    public float BulletVelocity = 10;

    private Transform player;

    private Rigidbody2D rigidBody;

    public GameObject EnermyPrefab;

    public float EnermyInterval = 5;

    private float nextEnermyTime;

    // Start is called before the first frame update
    void Start()
    {
        nextEnermyTime = Time.time + EnermyInterval;
        player = FindObjectOfType<Player>().transform;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // add the BulletPrefab above player
            Vector3 BulletPos = player.up + player.position;
            var bullet = Instantiate(BulletPrefab, BulletPos, Quaternion.identity);
            //add velocity to the BulletPrefab
            Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
            bulletRB.velocity = BulletVelocity * (bulletRB.transform.position - player.position);
        }

        if (Input.GetKeyDown(KeyCode.D) && player.position.x <= 7.4)
        {
            var newPos = player.position;
            newPos.x += (float)0.5;
            //rigidBody.AddForce(newPos - transform.position);
            player.position = newPos;

        }
        else if (Input.GetKeyDown(KeyCode.A) && player.position.x >= -7.4)
        {
            var newPos = player.position;
            newPos.x -= (float)0.5;
            player.position = newPos;
        }
        else if (Input.GetKeyDown(KeyCode.W) && player.position.y <= 4.0)
        {
            var newPos = player.position;
            newPos.y += (float)0.5;
            player.position = newPos;
        }
        else if (Input.GetKeyDown(KeyCode.S) && player.position.y >= -4.0)
        {
            var newPos = player.position;
            newPos.y -= (float)0.5;
            player.position = newPos;
        }


        if (Time.time > nextEnermyTime)
        {
            nextEnermyTime = Time.time + EnermyInterval;
            var newPosition = new Vector2(Random.Range((float)-7.4, (float)7.4), (float)4.0);
            Instantiate(EnermyPrefab, newPosition, Quaternion.identity);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // if enermy hits player, destory enermy and lose score
        if (collision.collider.name != "Bullet(Clone)" )
        {
            Destroy(collision.collider.gameObject);
            ScoreKeeper.ScorePoints(-1);
        }
    }
}
