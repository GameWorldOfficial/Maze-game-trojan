using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Next_Level : MonoBehaviour
{
    //load next maze level
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnTriggerEnter(Collider other) 
    {
        LoadNextLevel();
    }
}
