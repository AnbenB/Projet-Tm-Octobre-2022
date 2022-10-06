using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject Menupause;
    public GameObject Settings;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           if(isGamePaused)
           {
                Resume();
           }
           else

            {
                Paused();
            } 
        }
    }

    void Paused()
    {
        Menupause.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
        PlayerMovement.instance.enabled = false;
    }
    public void Resume()
    {
        Menupause.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
        PlayerMovement.instance.enabled = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        SauvegardePlayer.instance.Correction();
        Resume();


    }
    public void openSettingsMenu()
    {
        Settings.SetActive(true);
    }
    public void closeSettingsMenu()
    {
        Settings.SetActive(false);
    }









}
