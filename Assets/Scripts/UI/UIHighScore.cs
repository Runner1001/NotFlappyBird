using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHighScore : MonoBehaviour
{
    TMP_Text highScoreText;

    void Start()
    {
        highScoreText = GetComponent<TMP_Text>();
        ScoreManager.OnScoreChange += UpdateHighScoreText;
        UpdateHighScoreText(ScoreManager.HighScore);
    }

    void OnDestroy()
    {
        ScoreManager.OnScoreChange -= UpdateHighScoreText;
    }

    private void UpdateHighScoreText(int highScore)
    {
        highScoreText.SetText($"Your best score: {highScore}");
    }
}
