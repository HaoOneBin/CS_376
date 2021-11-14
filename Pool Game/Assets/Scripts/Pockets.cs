using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pockets : MonoBehaviour
{
    public static int count = 0;
    private AudioSource myAudioSource;
    public AudioClip beep;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name != "Player")
        {
            Destroy(collision.collider.gameObject);
            count++;
            myAudioSource.PlayOneShot(beep);
        }
            
    }
}
