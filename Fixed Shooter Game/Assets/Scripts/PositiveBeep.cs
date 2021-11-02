using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositiveBeep : MonoBehaviour
{
    public static AudioClip beep;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        beep = Resources.Load<AudioClip>("positive-beeps");
        audioSource = GetComponent<AudioSource>();        
    }

    public static void playSound()
    {
        audioSource.PlayOneShot(beep);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
