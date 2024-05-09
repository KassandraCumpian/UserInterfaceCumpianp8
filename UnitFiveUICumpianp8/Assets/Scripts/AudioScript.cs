using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour
{
    private AudioSource backgroundMusic;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVolumeMusic();
    }

    public void UpdateVolumeMusic()
    {
        backgroundMusic.volume = slider.value;
    }
}
