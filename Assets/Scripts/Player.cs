using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    int speed = 5;
    int jumpSpeed = 5;
    public  SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2( speed * movement, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Blue")
        {
            sprite.color = Color.blue;

        }
        if(collision.tag == "Red")
        {
            sprite.color = Color.red;
        }
    }
   void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Blue" || collision.tag == "Red")
        {
            sprite.color = Color.white;

        }
    }
}
