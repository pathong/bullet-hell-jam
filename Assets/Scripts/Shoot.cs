using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public Text textShow;
    public int bullet_count;
    private float Speed = 5f;
    public Transform fireBullet;
    public GameObject bullet_prefab;    private float timer = 2f;
    public float cooldowntimer_bullet = 1;
    private AudioSource audio_;
    void Update()
    {
        textShow.text = bullet_count.ToString();
        if (timer > 0)
        {
            timer -= Time.deltaTime * 8;
        }
        if (timer < 0)
        {
            timer = 0;
        }   
        if (timer == 0 && Input.GetMouseButtonDown(1))
        {
            if(bullet_count > 0)
            {
                Shoot_();
                audio_.Play();
                timer = cooldowntimer_bullet;
                bullet_count--;
            }

        }
    }

    public void Shoot_()
    {
        audio_ = gameObject.GetComponent<AudioSource>();
        GameObject bullet = Instantiate(bullet_prefab, fireBullet.position, fireBullet.rotation );
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(fireBullet.right * Speed, ForceMode2D.Impulse);
    }
}
