using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finished : MonoBehaviour
{
    [SerializeField] private AudioSource finishedSound;
    private bool levelCompleted = false;
   private  void Start()
    {
        finishedSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player"  && !levelCompleted)
        {
            finishedSound.Play();
            levelCompleted = true;  
            Invoke("CompletedLevel", 2f);
            
        }
    }
    private void CompletedLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
}
