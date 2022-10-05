using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    void Start()
    {
        gameObject.SetActive(false);
    }

    void OnEnable()
    {
        scoreText.SetText("Your Score: \n" + ScoreManager.Score);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
