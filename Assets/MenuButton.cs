using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    private Button PauseButton;
    public int scenenumber;
    public void onclick ()
    {
        SceneManager.LoadScene(scenenumber);
    }
    // Start is called before the first frame update
    void Awake()
    {
        PauseButton = GetComponent<Button>();
        if (PauseButton != null)
        {
            PauseButton.onClick.AddListener(onclick);
        }
    }

    // Update is called once per frame
   
}
