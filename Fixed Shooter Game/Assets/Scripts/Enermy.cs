using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    private Transform enermy;

    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        enermy = FindObjectOfType<Enermy>().transform;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var newPos = enermy.position;
        newPos.y -= (float)0.45;
        rigidBody.velocity = (newPos - transform.position);

        // if enermy off screen, destory enermy and lose score
        if (gameObject.transform.position.y < -4.47)
        {
            Destroy(gameObject);
            ScoreKeeper.ScorePoints(-1);
        }
    }

}
