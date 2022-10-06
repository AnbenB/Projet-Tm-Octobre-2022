using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
  public class NextLvl : MonoBehaviour
  {

    public GameObject portal;
    public Animator Transition;
    public GameObject player;

    public string Level;
    
    
        private void  OnTriggerEnter2D(Collider2D collision)
        {
              
             if(collision.CompareTag("Player"))
             {
            //SceneManager.LoadScene("Level03");
            //Transition.SetTrigger("Transition");
                player.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y); 
             }
             

            
        }
        public IEnumerator LoadNextScene()
        {
            Transition.SetTrigger("Transition");
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene("Level");


        }

    








}
