using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class Intro : MonoBehaviour
{
    public float wait_time = 5f ;
    void start()
    {
        StartCoroutine(Wait_for_intro());
    }
    IEnumerator Wait_for_intro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene("3");
    }
}
