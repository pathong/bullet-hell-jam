using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public AudioSource shoot_audio;
    public GameObject par;
    private float Speed = 10f;
    public Transform fireBullet;
    public GameObject bullet_prefab;
    public float timer = 9.99f;
    public float cooldowntimer_bullet =10;

    private void Start()
    {

    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            timer = 0;
        }
        if (timer == 0)
        {
            Shoot_();
            timer = cooldowntimer_bullet;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "bullet")
        {

            Instantiate(par, transform.position, Quaternion.identity);
        }
    }
    public void Shoot_()
    {
        shoot_audio.Play();
        GameObject bullet = Instantiate(bullet_prefab, fireBullet.position, fireBullet.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(fireBullet.right * Speed, ForceMode2D.Impulse);
    }
}
