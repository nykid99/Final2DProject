using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    PlayerMovement p1;
    public AudioClip ChestClip;
    private bool playerCollision;
    public bool alreadyPlayed = false;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Sprite openSprite, closedSprite;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            playerCollision = true;
        }
        if (playerCollision == true && alreadyPlayed == false)
        {
            spriteRenderer.sprite = openSprite;
            AudioSource.PlayClipAtPoint(ChestClip, transform.position);
            playerCollision = false;
            alreadyPlayed = true;

        }
    }
}
