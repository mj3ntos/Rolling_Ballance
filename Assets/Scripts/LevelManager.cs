using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public bool isPaused = false;
    public void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            if (isPaused)
            {
                Time.timeScale = 1f;
                isPaused = false;
            }
            else
          
            {
                Time.timeScale = 0f;
                isPaused = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

}