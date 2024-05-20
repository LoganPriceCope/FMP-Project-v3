using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    public Text MusicButton;
    private bool MusicButtonPressed = false;

    public Text SFXButton;
    private bool SFXButtonPressed = false;
    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
        if(MusicButtonPressed == false)
        {
            MusicButton.text = "OFF";
            MusicButtonPressed = true;
        }
        else
        {
            MusicButton.text = "ON";
            MusicButtonPressed = false;
        }
    }
    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSfx();
        if (SFXButtonPressed == false)
        {
            SFXButton.text = "OFF";
            SFXButtonPressed = true;
        }
        else
        {
            SFXButton.text = "ON";
            SFXButtonPressed = false;
        }
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }
    public void SFXVolume()
    {
        AudioManager.Instance.SFXVolume(_sfxSlider.value);
    }
}
