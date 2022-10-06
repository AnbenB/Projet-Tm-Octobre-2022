using UnityEngine;

public class Spawn : MonoBehaviour
{
    

    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = transform.position; // le joueur sera "téléporté" au Gameobject "Playerspawn".
    }
}
