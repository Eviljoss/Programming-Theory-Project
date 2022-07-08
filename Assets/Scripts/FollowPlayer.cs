using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    PlayerController playerScript;
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void LateUpdate()
    {
        if (!playerScript.gameOver)
        transform.position = player.transform.position + new Vector3(0,0,-10);
    }
}
