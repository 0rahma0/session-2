using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 3f;
    public Transform tr;
    public Vector3 startPos;
    public float jumpspeed = 10f;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        startPos = tr.position;
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Horizontal * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "lava")
        {
            tr.position = startPos;
        }

        if (collision.gameObject.tag == "ground")
        {
            tr.position = startPos;
        }

        if (collision.gameObject.tag == "ground")
        {
            isGrounded = true;
        }


    }
}
