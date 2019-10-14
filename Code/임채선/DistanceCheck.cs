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
    public Text bestscore;

    float max_distance = 0.0f;
    float Best;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.bottomcloud = GameObject.Find("bottomcloud");
        this.distance = GameObject.Find("Distance");
        this.ground = GameObject.Find("ground");
        Best = PlayerPrefs.GetFloat("Best", 0);
    }

    // Update is called once per frame
    void Update()
    {
        float Length = this.player.transform.position.y - this.ground.transform.position.y - 1.13f;
        if(max_distance < Length){
            max_distance = Length;
        }
        if(max_distance > Best){
                Best = max_distance;
            }
        if(Length >=0 ){
            this.distance.GetComponent<Text>().text = "최고 높이 : " + Best.ToString("F2") + "m" + "\n" + "현재 높이 : " + Length.ToString("F2") + "m";
        }
        else{
            this.distance.GetComponent<Text>().text = "최고 높이 : " + Best.ToString("F2") + "m" + "\n" + "게임 오버";
            GameOverScene.gameObject.SetActive(true);
            Time.timeScale = 0;
            bestscore.text = "역대 최고 높이 : " + Best.ToString("F2") + "m";
            score.text = "최고 높이 : " + max_distance.ToString("F2") + "m";
        }
        PlayerPrefs.SetFloat("Best", Best);
    }
    public void Restart(){
        SceneManager.LoadScene("catjump");
    }

    public void ToMain(){
        SceneManager.LoadScene("Title");
    }

    public void Over_Quit(){
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}