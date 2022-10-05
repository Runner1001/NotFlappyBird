using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static event Action<int> OnScoreChange;

    public static int Score { get; private set; }
    public static int HighScore { get; private set; }

    void Awake()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
        Score = 0;
    }

    public static void AddPoints(int points)
    {
        Score += points;
        OnScoreChange.Invoke(Score);

        if(Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
    }
}
