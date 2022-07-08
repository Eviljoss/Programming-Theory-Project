using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float speed = 1.2f;
    float jumpForce = 9.0f;
    bool isOnGround;
    public bool gameOver = false;
    Rigidbody playerRb;
    public TextMeshProUGUI winLevelText;
    public TextMeshProUGUI gameOverText;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        winLevelText.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
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
            gameOverText.gameObject.SetActive(true);
        }
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
        if (collision.gameObject.CompareTag("WinPlatform"))
        {
            winLevelText.gameObject.SetActive(true);
            gameOver = true;
        }
    }
}
