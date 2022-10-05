using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] GameObject optionsPanel;

    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider effectsSlider;

    private float masterVolume;
    private float musicVolume;
    private float effectsVolume;

    void Start()
    {
        optionsPanel?.SetActive(false);

        audioMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
        audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
        audioMixer.SetFloat("EffectsVolume", PlayerPrefs.GetFloat("EffectsVolume"));

        masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        effectsSlider.value = PlayerPrefs.GetFloat("EffectsVolume");
    }

    public void SetMasterVolume(float amount)
    {
        audioMixer.SetFloat("MasterVolume", amount);
        masterVolume = amount;
    }

    public void SetMusicVolume(float amount)
    {
        audioMixer.SetFloat("MusicVolume", amount);
        musicVolume = amount;
    }

    public void SetEffectsVolume(float amount)
    {
        audioMixer.SetFloat("EffectsVolume", amount);
        effectsVolume = amount;
    }

    public void SaveOptionsButton()
    {
        PlayerPrefs.SetFloat("MasterVolume", masterVolume);
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        PlayerPrefs.SetFloat("EffectsVolume", effectsVolume);
    }
}
