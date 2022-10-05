using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject optionsPanel;
    [SerializeField] private GameObject mainManuScene;

    bool isActive;

    void Start()
    {
        mainManuScene.SetActive(true);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
        mainManuScene.SetActive(false);
    }

    public void OptionsButton()
    {
        isActive = !isActive;

        if (isActive)
        {
            optionsPanel.SetActive(true);
        }
        else
        {
            optionsPanel.SetActive(false);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
