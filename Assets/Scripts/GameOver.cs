using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameOver instance;
    private void Awake()
   
    
    
    {


        if (instance != null)
        {

            return;

        }
        instance = this;


    }




    public void OnPlayerDeath()
    {
        gameOverUI.SetActive(true);
        if(CurrentSceneManager.instance.DefaultPlayer)
        {
            SauvegardePlayer.instance.Correction();

        }
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
        PlayerMovement.instance.enabled = true;
    }
    public void MainMenuButton()
    {
        SauvegardePlayer.instance.Correction(); // fait en sorte que quand on appuie sur "main menu" apr?s le level01, tout sera d?truit malgr? la sauvegarde(DontDestroyonload)
        
        SceneManager.LoadScene("MainMenu");

    }
    public void QuitButton()
    {
        Application.Quit();




    }


}
        
