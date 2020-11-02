using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
   

    public static bool gameispaused = false;
    public GameObject pausemenuUI;
    void Start()
    {
        Time.timeScale = 1f;
        pausemenuUI.SetActive(false);
        Cursor.visible = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                

            } else
            {
                Pause();
              
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            }
        }
    }


    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;
        Cursor.visible = true;
    }

    public void Load()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

}
