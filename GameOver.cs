using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string sceneName;
    private string detectionTag = "Player" ;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(detectionTag))
        {
        SceneManager.LoadScene(sceneName);
        }
    }
}