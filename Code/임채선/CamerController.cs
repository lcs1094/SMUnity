using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public Transform player;
    Transform p;
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        p.position = new Vector3(player.position.x, player.position.y, -10);
    }
}
