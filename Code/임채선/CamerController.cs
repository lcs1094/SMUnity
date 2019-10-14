using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public Transform player;    // 플레이어 오브젝트의 트랜스폼
    Transform p;                // 카메라의 트랜스폼 p
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<Transform>();  // 카메라에 트랜스포의 컴포넌트를 가져온다.
    }

    // Update is called once per frame
    void LateUpdate()
    {
        p.position = new Vector3(player.position.x, player.position.y, -10);    // 카메라의 위치 = 플레이어의 위치 (2D 이므로 z축 고정)
    }
}
