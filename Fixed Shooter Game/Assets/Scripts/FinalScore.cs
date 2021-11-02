using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    private TMP_Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay = GetComponent<TMP_Text>();
        scoreDisplay.text = "Your Score: " + PlayerPrefs.GetString("score"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
