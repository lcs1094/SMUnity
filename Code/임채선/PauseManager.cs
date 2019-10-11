using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject PausePanel;
    private bool paused = false;
    void start(){}
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Time.timeScale = 1;
                PausePanel.gameObject.SetActive(false);
                paused = false;
            }
            else
            {
                Time.timeScale = 0;
                PausePanel.gameObject.SetActive(true);
                paused = true;
            }

        }
    }
    
    public void Resume(){
        paused = false;
        Time.timeScale = 1;
        PausePanel.gameObject.SetActive(false);
    }
    public void Quit(){
        Application.Quit();
    }
    public void LoadGame2(){
        Time.timeScale = 1;
        SceneManager.LoadScene("Title");
    }
}
