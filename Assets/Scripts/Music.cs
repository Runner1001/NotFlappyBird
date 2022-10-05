using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; 

    public static Music Instance { get; private set; }

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);           
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
