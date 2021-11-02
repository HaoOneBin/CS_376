using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    bool FirstHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name != "Bullet(Clone)" && !FirstHit)
        {
            FirstHit = true;
            Destroy(gameObject);
            Destroy(collision.collider.gameObject);
            ScoreKeeper.ScorePoints(1);
        }
    }
}
