using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_controller : MonoBehaviour
{
    float Box_timer = 1.5f; // 생성 지속 시간
    float Box_Ontime = 0.0f; // 생성되고 나서부터의 시간
    GameObject player;
    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody2D>();
        
    }

    // void OnCollisionEnter2D(Collision2D col){
    //     if(col.transform.name =="player"){ // 공격 스킬 피격판정시
    //     // col.transform.tag로 사용 가능, 단, tag 사용시 모든 스킬의 tag 변경할 것
    //         Destroy(gameObject);
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        this.player = GameObject.Find("player");
        Box_Ontime += Time.deltaTime;     // 스킬 생성 이후 Time Ticks
        if(Box_Ontime > Box_timer)     // 스킬이 생성된 이후 스킬 지속시간만큼 흘렀으면 (스킬 지속시간이 끝났으면)
            Destroy(gameObject);            // 스킬 오브젝트 파괴
    }
}
