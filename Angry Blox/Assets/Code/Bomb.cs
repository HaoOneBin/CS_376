using UnityEngine;
using System.Collections.Generic;


public class Bomb : MonoBehaviour {
    public float ThresholdForce = 2;
    public GameObject ExplosionPrefab;

    private void Destruct()
    {
        Destroy(gameObject);
    }

    private void Boom()
    {
        GetComponent<PointEffector2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = false;
        
        // make it be a child of the box’s parent, so that
        // when the box goes away, it doesn’t take the explosion with it.
        Instantiate(ExplosionPrefab, transform.position, Quaternion.identity, transform.parent);

        Invoke("Destruct", 0.1f);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (GetComponent<Rigidbody2D>().velocity.magnitude >= ThresholdForce)
        {
            Boom();
        }
    }
}
