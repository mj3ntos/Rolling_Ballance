using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Znajdź LevelManager i wywołaj metodę LoadNextLevel
            FindObjectOfType<LevelManager>().LoadNextLevel();
        }
    }
}
