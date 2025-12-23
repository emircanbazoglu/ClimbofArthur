using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    bool zipla = true;
    public float jumpForce;
    float horizontal;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&zipla ==true)
        {
            rb.AddForce(new Vector2(0,jumpForce));
            zipla = false;
        }
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(horizontal * Time.deltaTime * speed, rb.velocity.y, 0);
    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="platform")
            
        {
            zipla = true;
        }
    }


}




