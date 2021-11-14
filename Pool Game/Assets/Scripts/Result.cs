using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Result : MonoBehaviour
{
    private TMP_Text result;
    // Start is called before the first frame update
    void Start()
    {
        result = GetComponent<TMP_Text>();
        result.text = "Your Record: " + PlayerPrefs.GetString("result");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
