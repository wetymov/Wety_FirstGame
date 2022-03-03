using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSc : MonoBehaviour
{
    public GameObject gameOver;
    public Text live;
    public bool JumpAllow = true;
    public int livescore = 5;
    public Transform groundCheck;
    public LayerMask groundMask;
    private bool ground = true;
    private float groundRadius = 0.5f;
    [SerializeField] bool Press;

    // Update is called once per frame
    private void Update()
    {
        if (livescore == 0)
        {
            gameOver.SetActive(true);
        }


        if (livescore < 0 || Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        print("OnCollisionEnter2D = " + collision.collider.name);
        
        if (collision.collider.tag == "Ground")
        {
            JumpAllow = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        print("OnCollisionExit2D = " + collision.collider.name);
        if (collision.collider.tag == "Ground")
        {
            JumpAllow = false;
        }
    }


    void OnCollisionStay2D(Collision2D collision)
    {
        print("OnCollisionStay2D = " + collision.collider.name);

    }


    private void Jump()
    {
        print("Jump");
        if (JumpAllow)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,8), ForceMode2D.Impulse);
        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            if (livescore <= 0)
            {
                live.text = "0";
            }
            else
            {
                livescore --;
                live.text = livescore.ToString();
            }
            
        }
    }
    


    public void ButtonJump()
    {
        Press = true;
        
    }
}
