using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper Singleton;
    public static void ScorePoints(int points)
    {
        Singleton.ScorePointsInternal(points);
    }

    /// <summary>
    /// Current score
    /// </summary>
    public static int Score;


    /// <summary>
    /// Text component for displaying the score
    /// </summary>
    private TMP_Text scoreDisplay;

    /// <summary>
    /// Initialize Singleton and ScoreDisplay.
    /// </summary>
    // ReSharper disable once UnusedMember.Local
    void Start()
    {
        Singleton = this;
        scoreDisplay = GetComponent<TMP_Text>();
        // Initialize the display
        ScorePointsInternal(0);
    }

    /// <summary>
    /// Internal, non-static, version of ScorePoints
    /// </summary>
    /// <param name="delta"></param>
    private void ScorePointsInternal(int delta)
    {
        // TODO
        Score += delta;
        if (delta > 0)
        {
            PositiveBeep.playSound();
        }
        if (delta < 0 && Time.time > 1)
        {
            NegativeBeep.playSound();
        }
        scoreDisplay.text = Score.ToString();

    }
}
