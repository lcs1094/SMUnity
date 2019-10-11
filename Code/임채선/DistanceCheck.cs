using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DistanceCheck : MonoBehaviour
{
    GameObject player;
    GameObject bottomcloud;
    GameObject distance;
    GameObject ground;
    public GameObject GameOverScene;
    public Text score;

    float max_distance = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
     this.player = GameObject.Find("player");
     this.bottomcloud = GameObject.Find("bottomcloud");
     this.distance = GameObject.Find("Distance");
     this.ground = GameObject.Find("ground");
    }

    // Update is called once per frame
    void Update()
    {
        float Length = this.player.transform.position.y - this.ground.transform.position.y - 1.13f;
        if(max_distance < Length){
            max_distance = Length;
        }
    
        if(Length >=0 ){
            this.distance.GetComponent<Text>().text = "최고 높이 : " + max_distance.ToString("F2") + "m" + "\n" + "현재 높이 : " + Length.ToString("F2") + "m";
        }
        else{
            this.distance.GetComponent<Text>().text = "최고 높이 : " + max_distance.ToString("F2") + "m" + "\n" + "게임 오버";
            GameOverScene.gameObject.SetActive(true);
            Time.timeScale = 0;
            score.text = "최고 높이 : " + max_distance.ToString("F2") + "m";
        }
    }
    public void Restart(){
        SceneManager.LoadScene("catjump");
    }

    public void ToMain(){
        SceneManager.LoadScene("Title");
    }

    public void Over_Quit() => Application.Quit();
}