using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIScore : MonoBehaviour
{
    TMP_Text scoreText;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        ScoreManager.OnScoreChange += UpdateScoreText;
        UpdateScoreText(ScoreManager.Score);
    }

    void OnDestroy()
    {
        ScoreManager.OnScoreChange -= UpdateScoreText;
    }

    private void UpdateScoreText(int score)
    {
        scoreText.SetText($"Score: {score}");
    }
}
