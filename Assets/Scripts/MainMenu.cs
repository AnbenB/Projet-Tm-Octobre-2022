using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string LoadLevel;

    public GameObject settingsWindow;
    
    
    public void StartGame()
    {
        SceneManager.LoadScene(LoadLevel);

    }

    public void Settings()
    {
        settingsWindow.SetActive(true);

    }
    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);

    }



    public void QuitGame()
    {
        Application.Quit();

    }











}
