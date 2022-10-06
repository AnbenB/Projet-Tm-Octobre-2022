using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{
   
   
    public bool DefaultPlayer = false;
    public static CurrentSceneManager instance;
    private void Awake()
    {


        if (instance != null)
        {

            return;

        }
        instance = this;

      

    }


}
