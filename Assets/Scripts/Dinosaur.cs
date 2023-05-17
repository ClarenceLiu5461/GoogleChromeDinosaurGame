using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    public GameObject Player;
    public Sprite DinoHit;
    public GameManager gm;
    public float jump;
    Rigidbody2D rb;
    bool isJumping;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = new Vector2(0, jump);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Cactus")
        {
            Player.GetComponent<SpriteRenderer>().sprite = DinoHit;
            gm.GameOver();
        }
        isJumping = false;
    }
}
