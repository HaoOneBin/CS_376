using UnityEngine;
using System.Collections.Generic;

public class TargetBox : MonoBehaviour
{
    /// <summary>
    /// Targets that move past this point score automatically.
    /// </summary>
    public static float OffScreen;

    SpriteRenderer box_SpriteRenderer;
    
    private Rigidbody2D box_rigidbody2D;

    private bool isAdded = false;

    internal void Start() {
        OffScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width-100, 0, 0)).x;
        box_SpriteRenderer = GetComponent<SpriteRenderer>();
        box_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    internal void Update()
    {
        if (transform.position.x > OffScreen)
            Scored();
    }

    private void Scored()
    {
        if (!isAdded)
        {
            isAdded = true;
            // Turn target box green    
            box_SpriteRenderer.color = Color.green;
            // Add score of mass
            ScoreKeeper.AddToScore(box_rigidbody2D.mass);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name != "Catapult Base")
        {
            if (collision.collider.tag == "Ground")
            {
                Scored();
            }
        }

    }
}
