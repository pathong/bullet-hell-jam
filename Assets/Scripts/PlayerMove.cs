using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public AudioSource jump_audio;
    public GameObject par;
    private float speed = 5;
    private float jump = 2;
    public GameObject rayOrigin;
    private float rayCheckDistance = 0.1f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            Instantiate(par, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "enemy_bullet")
        {
            Instantiate(par, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Jump") > 0)
        {
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin.transform.position, Vector2.down, rayCheckDistance);
            if (hit.collider != null) //(hit.collider.tag == "ground" || hit.collider.tag == "block")
            {
                if(hit.collider.gameObject.tag != "boss" &&  hit.collider.gameObject.tag != "portal"){
                    jump_audio.Play();
                    rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
                }

            }
        }
        rb.velocity = new Vector3(x * speed, rb.velocity.y, 0);

    }
}
