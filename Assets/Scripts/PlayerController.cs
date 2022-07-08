using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float speed = 1.0f;
    float jumpForce = 7.0f;
    bool isOnGround;
    public bool gameOver = false;
    Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.right * speed * horizontalInput);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        if (transform.position.y < -10)
        {
            gameOver = true;
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
