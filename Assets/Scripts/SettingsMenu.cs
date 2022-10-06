using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
public class SettingsMenu : MonoBehaviour
{
    Resolution[] resolutions;

    public Dropdown resolutionDropdown;

    public void Start()                                                     // Le Distinct permet qu'il n'y ait pas de duplications de resolutions
    {
        resolutions = Screen.resolutions.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i]. width +  "x" + resolutions[i].height;
            options.Add(option);
        }

        resolutionDropdown.AddOptions(options);
    
    }
    public AudioMixer audiomixer;
    public void Volume(float volume)
    
    {
        audiomixer.SetFloat("Musique", volume);
    }

    public void SoundVolume(float volume)

    {
        audiomixer.SetFloat("Sound", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        
            Screen.fullScreen = isFullScreen;

    }

    public void SetResolution(int resolutionIndex)
    {

        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);




    }
}
