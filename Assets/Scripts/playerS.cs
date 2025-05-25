using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerS : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpH;

    public Animator flapping;
    public Animator death;
    public bool gameOver;

    public GameObject gameOverScene;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && gameOver == false)
        {
            rb.AddForce(Vector2.up * jumpH, ForceMode2D.Impulse);
            flapping.Play("playerFlap");
        }

        if(gameOver == true)
        {
            gameOverScene.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void jumping()
    {
        if(gameOver == false)
        {
            rb.AddForce(Vector2.up * jumpH, ForceMode2D.Impulse);
            flapping.Play("playerFlap");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            death.Play("playerDeath");
            gameOver = true;
        }
    }
}
