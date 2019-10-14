using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void LoadGame() => SceneManager.LoadScene("catjump");

    public void Quit(){
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
