using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Generatoir : MonoBehaviour
{
    public GameObject boxcloud;   // 프리팹 사용을 위해 public으로 설정
    GameObject player;
    float Box_Active = 1.2f;  // 생성 쿨타임
    float Box_timer = 0.0f;   // 생성 측정용 변수
    int movementFlag;
    Vector3 StartPoint = new Vector3(0,-5,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.player = GameObject.Find("player");
        movementFlag = Random.Range(0,2);
        Box_timer += Time.deltaTime;  // 스킬 발동을 위한 시간 측정
        if(Box_timer > Box_Active){ // 스킬 발동을 위한 시간이 쿨타임만큼 지나면
            Box_timer = 0.0f;         // 시간 변수 초기화
            GameObject skill = Instantiate(boxcloud) as GameObject;   // 스킬 오브젝트 프리팹으로 생성
            if(movementFlag == 0){
                Vector3 aboveVec = new Vector3(2.5f,3.0f,0f);
                skill.transform.position = StartPoint + aboveVec;    // 스킬의 위치는 player 오브젝트의 위치 기준으로 생성
                StartPoint = skill.transform.position;
            }
            else{
                Vector3 aboveVec = new Vector3(-2.5f,3.0f,0f);
                skill.transform.position = StartPoint + aboveVec;    // 스킬의 위치는 player 오브젝트의 위치 기준으로 생성
                StartPoint = skill.transform.position;
            }
        }   
    }
}
