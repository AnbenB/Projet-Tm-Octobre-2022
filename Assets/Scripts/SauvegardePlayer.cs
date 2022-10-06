using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SauvegardePlayer : MonoBehaviour
{
    public GameObject[] objects;

    public static SauvegardePlayer instance;
    private void Awake()
    {


        if (instance != null)
        {

            return;

        }
        instance = this;

        foreach (var element in objects)
        {
            DontDestroyOnLoad(element);


        }

    }




    public void Correction()
    {
        foreach (var element in objects)
        {
            SceneManager.MoveGameObjectToScene(element, SceneManager.GetActiveScene());


        }



    }
}