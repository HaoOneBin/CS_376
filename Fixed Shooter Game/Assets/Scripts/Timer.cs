using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private TMP_Text timerDisplay;

    public float timeLeft = 60;

    // Start is called before the first frame update
    void Start()
    {
        timerDisplay = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            //DisplayTime(timeLeft);
            timerDisplay.text = (int)timeLeft / 60 + ":" + (int)timeLeft % 60;
        }
        else
        {
            timeLeft = 0;
            SceneManager.LoadScene(sceneName: "Ending");
            PlayerPrefs.SetString("score", ScoreKeeper.Score.ToString());
        }
    }
}
