using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private TMP_Text timerDisplay;
    // Start is called before the first frame update
    void Start()
    {
        timerDisplay = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerDisplay.text = (int)Time.time / 60 + ":" + (int)Time.time % 60;
        
        if (Pockets.count == 6)
        {
            SceneManager.LoadScene(sceneName: "Ending");
            PlayerPrefs.SetString("result", timerDisplay.text.ToString());
        }
    }
}
