using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public int totalScore;
    public CharacterController2D controller;
    public Animator animator;
    public AudioClip deadClip;

    public float runSpeed = 25f;
    float horizontalMove = 0f;
    bool jumpFlag = false;
    bool jump = false;
    bool GameOver = false;



    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (jumpFlag)
        {
            jumpFlag = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    public void OnLanding()
    {
        jump = false;
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);

        if (jump)
        {
            jumpFlag = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            AudioSource.PlayClipAtPoint(deadClip, transform.position);
            Destroy(this.gameObject);
            GameOver = true;
        }
        if (collision.gameObject.layer == 13)
        {
            SceneManager.LoadScene(1);
        }
        if(collision.gameObject.layer == 14)
        {
            SceneManager.LoadScene(2);
        }
<<<<<<< HEAD
        /*if (collision.gameObject.layer == 9)
        {
            GameObject.Destroy(this.gameObject);
            GameControlScript.health -= 1;
            //GameObject.Destroy(collision.gameObject);
        }*/
=======
>>>>>>> parent of 3ae9260... Added Scene 2 still working on hearts
    }
}
